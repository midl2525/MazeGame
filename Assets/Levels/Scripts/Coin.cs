using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        LevelContoller.Instance.SetCoin(1);
        Destroy(gameObject);
    }
}
