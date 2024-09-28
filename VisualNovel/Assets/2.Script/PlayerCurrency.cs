using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{
    public int currency = 100; // 시작 금액

    public bool CanAfford(int cost)
    {
        return currency >= cost;
    }

    public void SpendCurrency(int cost)
    {
        if (CanAfford(cost))
        {
            currency -= cost;
        }
    }
}

