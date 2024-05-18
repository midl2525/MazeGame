using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsController : Sound
{
    [SerializeField] private SkinsView _skinsView;
    [SerializeField] private SkinsData _skinsData;

    [SerializeField] private CoinsView _coinsView;

    private CoinsHolder _coinsHolder;

    private void Start()
    {
        _coinsHolder = new CoinsHolder();
        LoadSkins();
        _coinsView.DisplayCoins(_coinsHolder.Coins);
        if (Bootstrap.Instance.IsFirstStart) SetStartSkin();
    }

    public void CheckingIsHave(int id)
    {
        PlaySound(Sounds[0]);
        if (PlayerPrefs.GetInt(Constants.Local.Save.SKINISHAVE + id) > 0) Use(id);
        else Buy(id);
    }

    private void Buy(int id)
    {
        _coinsHolder.LoadCoins();
        if (_skinsData.SkinConfigs[id].Price > _coinsHolder.Coins) return;

        _coinsHolder.SetCoins(_coinsHolder.Coins - _skinsData.SkinConfigs[id].Price);
        _coinsView.DisplayCoins(_coinsHolder.Coins);

        SaveSkin(id);
        Use(id);

        _skinsView.DisplaySkin(true, _skinsData.SkinConfigs[id], id);
    }

    private void Use(int id)
    {
        PlayerPrefs.SetInt(Constants.Local.Save.SKINID, id);
        PlayerPrefs.Save();
    }

    

    private void LoadSkins()
    {
        List<bool> isHave = new List<bool>();

        for (int i = 0; i < _skinsData.SkinConfigs.Count; i++)
        {
            if (PlayerPrefs.GetInt(Constants.Local.Save.SKINISHAVE + i) > 0) isHave.Add(true);
            else isHave.Add(false);
        }

        _skinsView.DisplayAllSkins(isHave, _skinsData.SkinConfigs);
    }

    private void SetStartSkin()
    {
        Buy(0);
    }

    private void SaveSkin(int id)
    {
        PlayerPrefs.SetInt(Constants.Local.Save.SKINISHAVE + id, 1);
        PlayerPrefs.Save();
    }

#if UNITY_EDITOR
    [ContextMenu("Set Coins 100")]
    public void SetCoins()
    {
        _coinsHolder.SetCoins(200);
        _coinsView.DisplayCoins(_coinsHolder.Coins);
    }
#endif
}
