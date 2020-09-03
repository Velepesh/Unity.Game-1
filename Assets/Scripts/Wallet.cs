using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    private int _coin;

    public event UnityAction<int> CoinChanged;

    public void AddCoin()
    {
        _coin++;

        CoinChanged?.Invoke(_coin);
    }
}
