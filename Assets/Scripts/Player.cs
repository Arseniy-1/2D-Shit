using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private bool _hasKey = false;

    public int MoneyCount { get; private set; } = 0;

    public void AddCoin()
    {
        MoneyCount++;
        _text.text = MoneyCount.ToString();
    }
}
