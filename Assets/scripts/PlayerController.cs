using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IMovementBehaviour))]
[RequireComponent (typeof(InputManager))]
[RequireComponent(typeof (HealthBehaviour))]  
public class PlayerController : MonoBehaviour
{
    IMovementBehaviour _mb;
    InputManager _input;
    HealthBehaviour _hb;
    private void Awake()
    {
        _hb = GetComponent<HealthBehaviour>();  
        _mb = GetComponent<IMovementBehaviour>();
        _input = GetComponent<InputManager>();
        GameManager.instance.playerHealth = _hb;
    }

    private void Start()
    {
    }
    private void FixedUpdate()  
    {
        if (_input.rotate != Vector2.zero)
        {
            _mb.Rotate(_input.rotate);
        }

        var dir = transform.forward * _input.movement.y + transform.right * _input.movement.x;
        _mb.Move(dir);


    }
}
