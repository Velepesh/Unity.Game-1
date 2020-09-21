using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Player _target;

    private void FixedUpdate()
    {
        transform.position = new Vector3(_target.transform.position.x, transform.position.y, transform.position.z);
    }
}
