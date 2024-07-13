using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private float _maxScale = 1.5f;
    private Vector3 _direction = Vector3.one;
    private Vector3 _startScale;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        if (transform.localScale.magnitude > _startScale.magnitude * _maxScale || transform.localScale.magnitude < _startScale.magnitude)
            _direction *= -1;

        transform.localScale += _direction * Time.deltaTime * _speed;
    }
}
