using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : BulletBase
{
    Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }


////public override void Activate()
//    {
//        throw new System.NotImplementedException();
//    }


    
    //void Update()
    //{
    //    Vector2 velo = PlayerMoveScript._mousePos - gameObject.transform.position;
    //    _rb.AddForce(velo * _bulletSpeed, ForceMode2D.Force);
    //}
}
