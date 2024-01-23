using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovementBehaviour
{
    public void Move();
    public void Move(Vector3 dir);
    public void Move(Vector3 dir, float speed);
    public void MoveToPoint(Vector3 target);
    public void MoveToPoint(Vector3 target, float speed);
    public void Rotate(Vector2 rotation);
}
