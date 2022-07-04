using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    //[SerializeField] float _speed = 1f;
    Vector2 _initialPosition;
    float _timer;

    void Start()
    {
        _initialPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        //float posY = -1 * _timer * _speed;
        //Vector2 pos = _initialPosition + new Vector2(_initialPosition.x, posY);
        //transform.position = pos;
    }
}
