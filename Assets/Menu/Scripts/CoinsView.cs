using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinsView : MonoBehaviour
{
    [SerializeField] private TMP_Text _textCoins;

    public void DisplayCoins(int coins)
    {
        _textCoins.text = coins.ToString();
    }
}
