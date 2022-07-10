using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] _enemy;
    [SerializeField] Transform[] _generatePoint;
    [SerializeField] float _Interval = 5;
    [SerializeField] float _generateSpeed = 0.05f;
    float _timer;
    int _number;
    int _pointnumber;
    int _enemyNumber;

    
    void Update()
    {
        EnemyGenerate();
    }

    void EnemyGenerate()
    {
        if (TimeManager._startGame)
        {
            _timer += Time.deltaTime;
        }


        if (_timer > _Interval)
        {
            _timer = 0;

            _Interval -= _generateSpeed;

            _enemyNumber = Random.Range(1, _enemy.Length);
            
            for (int i = 0; i < _enemyNumber; i++)
            {
                _number = Random.Range(0, _enemy.Length);
                _pointnumber = Random.Range(0, _generatePoint.Length);

                Instantiate(_enemy[_number], _generatePoint[_pointnumber]);
            }
        }

        if (_Interval < 0.4)
        {
            _Interval = 0.4f;
        }
    }
}
