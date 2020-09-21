using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.TryGetComponent(out Wallet wallet))
        {
            wallet.AddCoin();
            Destroy(gameObject);
        }
    }
}