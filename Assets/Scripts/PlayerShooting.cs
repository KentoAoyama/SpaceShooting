using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] GameObject _bullet;
    [SerializeField] Transform _muzzle;
    [SerializeField] float _shootInterval = 0.2f;
    float _timer;
    

    void Update()
    {
        if (TimeManager._startGame)
        {
            _timer += Time.deltaTime;
        }
        
        if (Input.GetButton("Fire2") && _timer > _shootInterval)
        {
            _timer = 0;
            Instantiate(_bullet, _muzzle.position, this.transform.rotation);
        }
    }
}
