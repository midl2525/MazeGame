using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsHolder 
{
    public int Coins { get; private set; }

    public CoinsHolder()
    {
        LoadCoins();
    }

    public void SetCoins(int value)
    {
        Coins = value;
        PlayerPrefs.SetInt(Constants.Local.Save.COINS, Coins);
        PlayerPrefs.Save();
    }

    public void LoadCoins()
    {
        Coins = PlayerPrefs.GetInt(Constants.Local.Save.COINS);
    }

}
