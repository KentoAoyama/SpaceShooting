using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Script : EnemyBase
{
    [SerializeField] float _moveSpeed = 0.005f;
    [SerializeField] float _turnLenge = 5;
    Vector2 _enemy2Position;
    bool _moveChange = false;


    void Start()
    {
        _enemy2Position = transform.position;
        
        _player = GameObject.FindWithTag("Player");

        _enemyScore = 300;

        _ps = GetComponent<ParticleSystem>();
    }


    public override void Move()
    {
        float dis = Vector2.Distance(_player.transform.position, transform.position);

        if (dis < _turnLenge)
        {
            _moveChange = true;
        }

        if (!_moveChange)
        {
            _enemy2Position.x += (_player.transform.position.x - _enemy2Position.x) * _moveSpeed;
            _enemy2Position.y += (_player.transform.position.y - _enemy2Position.y) * _moveSpeed;
            transform.position = _enemy2Position;
        }
        else
        {
            _enemy2Position.x += (_player.transform.position.x - _enemy2Position.x) * _moveSpeed * -1;
            _enemy2Position.y += (_player.transform.position.y - _enemy2Position.y) * _moveSpeed * -1;
            transform.position = _enemy2Position;
        }
    }
}
