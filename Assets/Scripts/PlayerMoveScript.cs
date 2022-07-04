using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 2f;
    Rigidbody2D _rb;
    public static Vector3 _mousePos;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _mousePos = Input.mousePosition;
        _mousePos = Camera.main.ScreenToWorldPoint(_mousePos);
        _mousePos.z = 0;

        transform.up = _mousePos - this.gameObject.transform.position;

        if (Input.GetButton("Fire1"))
        {
            _rb.AddForce(transform.up * _moveSpeed, ForceMode2D.Force);
        }

    }
}
