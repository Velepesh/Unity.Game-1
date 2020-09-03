using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WalletDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _walletText;
    [SerializeField] private Wallet _wallet;

    private void OnEnable()
    {
        _wallet.CoinChanged += OnCoinChanged;
    }

    private void OnDisable()
    {
        _wallet.CoinChanged -= OnCoinChanged;
    }

    private void OnCoinChanged(int money)
    {
        _walletText.text = money.ToString();
    }
}
