using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    
    private Vector3 _direction = Vector3.up;

    private void Update()
    {
        transform.Rotate(_direction * _speed);
    }
}
