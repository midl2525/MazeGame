using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSkin : MonoBehaviour
{
    [SerializeField] private SkinsData _skinsData;
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        SetSkin();
    }

    private void SetSkin()
    {
        _spriteRenderer.sprite = _skinsData.SkinConfigs[PlayerPrefs.GetInt(Constants.Local.Save.SKINID)].Sprite;
    }
}
