using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBehaviour : MonoBehaviour
{
    public int heal = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<HealthBehaviour>(out var health))
        {
            health.heal(heal);
            Destroy(gameObject);
        }
    }
}
