using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class RigidBodyMovementBehaviour : MonoBehaviour, IMovementBehaviour
{
    private Rigidbody _rb;
    private Vector3 _dir = Vector3.forward;
    private float _speed = 5f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.up + transform.position,Vector3.up + transform.position + _dir);
    }
    public void Move()
    {
        _rb.velocity = new Vector3(_dir.x * _speed, _rb.velocity.y, _dir.z * _speed);
    }

    public void Move(Vector3 dir)
    {
        setDir(dir);
        Move();
    }

    public void Move(Vector3 dir, float speed)
    {
        setSpeed(speed);
        setDir(dir);
        Move();
    }

    public void setDir(Vector3 dir) { _dir = dir; }

    public void setSpeed(float speed) { _speed = speed; }

    public void MoveToPoint(Vector3 target)
    {
        throw new System.NotImplementedException();
    }

    public void MoveToPoint(Vector3 target, float speed)
    {
        throw new System.NotImplementedException();
    }

    public void Rotate(Vector2 rotation) 
    {
        float rot = rotation.x;
        _rb.rotation *= Quaternion.Euler(0, rotation.x, 0);
    }
    
}
