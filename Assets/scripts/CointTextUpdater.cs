using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CointTextUpdater : MonoBehaviour
{
    TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        GameManager.instance.playerCoins.OnGrabCoin += UpdateCoinsText;
    }

    public void UpdateCoinsText(int coins)
    {
        text.text = "coins: " + coins.ToString();
    }
}
