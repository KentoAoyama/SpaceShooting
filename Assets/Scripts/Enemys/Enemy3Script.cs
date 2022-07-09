using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Script : EnemyBase
{
    [SerializeField] float _moveSpeed = 0.005f;
    [SerializeField] float _turnSpeed = 0.1f;
    [SerializeField] float _turnLenge = 5;
    Vector2 _enemy2Position;
    Vector2 _initialPosition;


    void Start()
    {
        _enemy2Position = transform.position;

        _initialPosition = transform.position;

        _player = GameObject.FindWithTag("Player");
    }


    public override void Move()
    {
        float dis = Vector2.Distance(_player.transform.position, transform.position);

        if (dis > _turnLenge)
        {
            _enemy2Position.x += (_player.transform.position.x - _enemy2Position.x) * _moveSpeed;
            _enemy2Position.y += (_player.transform.position.y - _enemy2Position.y) * _moveSpeed;
            transform.position = _enemy2Position;
        }
        else if (dis <= _turnLenge)
        {
            float posX = Mathf.Sin(_turnSpeed * _timer) * _turnLenge;
            float posY = Mathf.Cos(_turnSpeed * _timer) * _turnLenge;
            posY += _player.transform.position.y;
            transform.position = new Vector2(posX, posY);
        }
    }
}
