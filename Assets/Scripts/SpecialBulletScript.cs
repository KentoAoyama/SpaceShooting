using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBulletScript : BulletBase
{
    Rigidbody2D _rb;
    float _timer;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velo = PlayerMoveScript._mousePos - gameObject.transform.position;
        _rb.AddForce(velo * _bulletSpeed, ForceMode2D.Force);

        _timer += Time.deltaTime;

        if (_timer > 10)
        {
            Destroy(gameObject);
        }
    }
}
