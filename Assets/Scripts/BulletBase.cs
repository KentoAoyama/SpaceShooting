using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletBase : MonoBehaviour
{
    public float _bulletSpeed = 10;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "BackGround")
        {
            Destroy(gameObject);
        }
    }
}
