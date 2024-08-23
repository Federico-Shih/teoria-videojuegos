using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMovable 
{
    float WalkSpeed { get; }
    float RunSpeed { get; }
    bool IsRunning { get; }

    void Move(Vector3 dir);

}
