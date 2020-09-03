using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    readonly private Vector3 _slopeLimit = new Vector3(1f, 0f, 0f);

    public UnityAction PlayerDied;

    private void OnCollisionStay(Collision collision)
    {
        Vector3 collisionDirection = collision.GetContact(0).normal;

        if(Mathf.Abs(collisionDirection.x) == _slopeLimit.x || collisionDirection.y < _slopeLimit.y)
        {
            PlayerDied?.Invoke();
        }
    }
}