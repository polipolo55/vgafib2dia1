using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private void FixedUpdate()
    {
        transform.rotation *= Quaternion.Euler(Vector3.right);
    }
}
