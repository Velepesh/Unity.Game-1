using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private readonly float _angleLimit = 135f;

    public event UnityAction PlayerDied;

    private void OnCollisionStay(Collision collision)
    {
        Vector3 collisionDirection = collision.GetContact(0).normal;

        float collisionAngle = (Vector3.Angle(Vector3.right, collisionDirection));

        if (collisionAngle > _angleLimit)
        {
            PlayerDied?.Invoke();
        }
    }
}