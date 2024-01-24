using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavMeshBehaviour : MonoBehaviour, IMovementBehaviour
{
    NavMeshAgent _agent;
    private Vector3 _dir = Vector3.forward;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.speed = 2f;
    }

    public void Move()
    {
        _agent.Move(new Vector3(_dir.x * _agent.speed * Time.fixedDeltaTime, 0, _dir.z * _agent.speed * Time.fixedDeltaTime));
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

    public void MoveToPoint(Vector3 target)
    {
        _agent.destination = target;
    }

    public void MoveToPoint(Vector3 target, float speed)
    {
        _agent.destination = target;
    }

    public void Rotate(Vector2 rotation)
    {
        throw new System.NotImplementedException();
    }

    public void setDir(Vector3 dir) { _dir = dir; }

    public void setSpeed(float speed) { _agent.speed = speed; }

    public float getSpeed() { return _agent.velocity.magnitude; }
}
