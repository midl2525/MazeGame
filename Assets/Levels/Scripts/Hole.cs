using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        LevelContoller.Instance.CollisionHole();
        _animator.SetTrigger("ColliderHole");
    }

    private void EventLose()
    {
        LevelContoller.Instance.Lose();
    }

}
