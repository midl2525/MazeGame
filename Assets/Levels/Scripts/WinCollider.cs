using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelContoller.Instance.Win();
        Destroy(collision.gameObject);
    }
}

