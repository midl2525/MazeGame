using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinsView : IMenuPanel
{
    [SerializeField] private List<SkinItemView> _skinItemViews;

    public void DisplayAllSkins(List<bool> isHave, List<SkinConfig> skinConfig)
    {
        for (int i = 0; i < _skinItemViews.Count; i++)
        {
            SkinConfig currentSkinConfig = skinConfig[i];
            bool currentIsHave = isHave[i];

            DisplaySkin(currentIsHave, currentSkinConfig, i);
        }
    }

    public void DisplaySkin(bool isHave, SkinConfig skinConfig, int id)
    {
        _skinItemViews[id].DisplaySkin(skinConfig.Sprite);
        _skinItemViews[id].DisplayPrice(skinConfig.Price);
        _skinItemViews[id].DisplayIsHave(isHave);
    }
    public override void Open()
    {
        gameObject.SetActive(true);
    }

    public override void Close()
    {
        gameObject.SetActive(false);
    }
}
