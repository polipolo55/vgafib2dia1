using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    public int amount = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<CollectionableBehaviour>(out var coins))
        {
            coins.AddCoins(amount);
            Destroy(gameObject);
        }
    }
}
