using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    public GameObject _player;
    public float _timer;
    [SerializeField] float _aliveTimer = 5;
    public ParticleSystem _ps;
    public int _enemyScore = 0;
    bool _isDeath;
    

    public abstract void Move();

    void Update()
    {
        _timer += Time.deltaTime;

        if (!_isDeath)
        {
            Move();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "StageLimit" && _timer > _aliveTimer)
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Player")
        {
            ShootDown();
        }
    }

    /// <summary>ÉvÉåÉCÉÑÅ[Ç…Ç‚ÇÁÇÍÇΩéûÇÃèàóù</summary>
    void ShootDown()
    {
        if (!_isDeath)
        {
            _isDeath = true;
            ScorePlus();
            _ps.Play();
            Destroy(this.gameObject, 0.3f);
        }
    }

    void ScorePlus()
    {
        FindObjectOfType<ScoreManager>().Score(_enemyScore);
    }

}
