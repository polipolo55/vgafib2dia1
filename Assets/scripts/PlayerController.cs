using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IMovementBehaviour))]
[RequireComponent (typeof(InputManager))]
[RequireComponent(typeof (HealthBehaviour))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    IMovementBehaviour _mb;
    InputManager _input;
    HealthBehaviour _hb;
    CollectionableBehaviour _coll;
    Animator _anim;
    private void Awake()
    {
        _hb = GetComponent<HealthBehaviour>();  
        _coll = GetComponent<CollectionableBehaviour>();
        _mb = GetComponent<IMovementBehaviour>();
        _input = GetComponent<InputManager>();
        _anim = GetComponent<Animator>();
        GameManager.instance.playerHealth = _hb;
        GameManager.instance.playerCoins = _coll;
    }

    private void Start()    
    {
    }
    private void Update()
    {
        _anim.SetBool("jeje", _input.isShooting);
    }

    private void FixedUpdate()  
    {
        if (_input.rotate != Vector2.zero)
        {
            _mb.Rotate(_input.rotate);
        }

        var dir = transform.forward * _input.movement.y + transform.right * _input.movement.x;
        _mb.Move(dir);
        _anim.SetFloat("velocity", _mb.getSpeed());


    }
}
