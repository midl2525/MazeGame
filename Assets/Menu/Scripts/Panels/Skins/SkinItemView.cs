using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkinItemView : MonoBehaviour
{
    [SerializeField] private Image _iconSkin;

    [SerializeField] private TMP_Text _textBuy;
    [SerializeField] private TMP_Text _textUse;

    [SerializeField] private string _suffixBuy;

    public void DisplaySkin(Sprite icon)
    {
        _iconSkin.sprite = icon;
    }

    public void DisplayIsHave(bool isHave)
    {
        _textUse.gameObject.SetActive(isHave);
        _textBuy.gameObject.SetActive(!isHave);
    }

    public void DisplayPrice(int price)
    {
        _textBuy.text = $"{_suffixBuy} {price}";
    }
}
