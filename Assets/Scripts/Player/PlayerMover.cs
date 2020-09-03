using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private LayerMask _layerMask;

    private Rigidbody _rigidbody;
    private float _checkDistance = 1f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 velocity = _rigidbody.velocity;

        velocity.x = _speed;

        if (IsGrounded() && Input.GetKey(KeyCode.Space))
        {
            velocity.y = _jumpForce;
        }

        _rigidbody.velocity = velocity;
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, _checkDistance, _layerMask);
    }
}