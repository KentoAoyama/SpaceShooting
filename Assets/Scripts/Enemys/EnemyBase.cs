using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public GameObject _player;
    public float _timer;
    public float _aliveTimer = 5;


    public abstract void Move();


    void Update()
    {
        _timer += Time.deltaTime;

        Move();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "BackGround" && _timer > _aliveTimer)
        {
            Destroy(gameObject);
        }
    }
}
