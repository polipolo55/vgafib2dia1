using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionableBehaviour : MonoBehaviour
{
    private int NumOfCoins = 0;
    public event Action<int> OnGrabCoin = delegate { };

    private void Start()
    {
        OnGrabCoin.Invoke(NumOfCoins);
    }

    public void AddCoins(int n)
    {
        NumOfCoins += n;
        OnGrabCoin.Invoke(NumOfCoins);
    }
}
