using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : EnemyBase
{
    [SerializeField] float _moveSpeed = 0.005f;
    Vector2 _enemy2Position;


    void Start()
    {
        _enemy2Position = transform.position;

        _player = GameObject.FindWithTag("Player");
    }


    public override void Move()
    {
        _enemy2Position.x += (_player.transform.position.x - _enemy2Position.x) * _moveSpeed;
        _enemy2Position.y += (_player.transform.position.y - _enemy2Position.y) * _moveSpeed;
        transform.position = _enemy2Position;
    }

}
