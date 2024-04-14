using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextMoney : MonoBehaviour
{
    int money = Royalists.Money;
    public TextMeshProUGUI moneyView;
    void Start()
    {
        moneyView.text = "Argent = " + money;
    }

    void Update()
    {
        
    }
}
