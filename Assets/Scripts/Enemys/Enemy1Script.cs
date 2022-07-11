using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Script : EnemyBase
{
    [SerializeField] float _speedX = 1f;
    [SerializeField] float _speedY = 1f;
    [SerializeField] float _amplitude = 1.5f;
    Vector2 _initialPosition;


    void Start()
    {       
        _initialPosition = transform.position;

        if (transform.position.y > 0)
        {
            _speedY *= -1;
        }

        _enemyScore = 200;

        _ps = GetComponent<ParticleSystem>();
    }

    public override void Move()
    {
        float posY = _timer * _speedY;
        float posX = Mathf.Sin(_speedX * _timer) * _amplitude;
        Vector2 pos = _initialPosition + new Vector2(posX, posY);
        transform.position = pos;
    }
}
