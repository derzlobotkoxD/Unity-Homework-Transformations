using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;

    private float _maxDistance = 3f;
    private Vector3 _direction = Vector3.forward;
    private Vector3 _maxPosition;

    private void Start()
    {
        _maxPosition = transform.position + _direction * _maxDistance;
    }

    private void Update()
    {
        if (transform.position.magnitude >= _maxPosition.magnitude)
            _direction *= -1;

        transform.position += _direction * _speed * Time.deltaTime;
    }
}
