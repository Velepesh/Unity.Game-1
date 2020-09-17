using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    private int _coins;

    public event UnityAction<int> CoinChanged;

    public void AddCoin()
    {
        _coins++;

        CoinChanged?.Invoke(_coins);
    }
}