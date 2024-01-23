using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthTextUpdater : MonoBehaviour
{
    TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Start()
    {
        GameManager.instance.playerHealth.OnHealthChange += UpdateHealthText;
    }

    public void UpdateHealthText(int health)
    {
        text.text = "health: " + health.ToString();
    }
}
