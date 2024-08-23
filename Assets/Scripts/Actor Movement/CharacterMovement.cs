using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour, IMovable
{
    #region IMOVABLE_PROPERTIES
    public float RunSpeed => _runSpeed;
    [SerializeField] private float _runSpeed;

    public float WalkSpeed => _walkSpeed;
    [SerializeField] private float _walkSpeed;

    public bool IsRunning => _isRunning;
    [SerializeField] private bool _isRunning;

    #endregion

    #region UNITY_EVENTS
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    #endregion

    #region IMOVABLE_METHODS
    public void Move(Vector3 dir)
    {
        // Podemos acceder directamente al transform
        // deltaTime: movimiento uniforme en base a los frames.
        transform.position += dir * Time.deltaTime * (IsRunning ? _runSpeed : _walkSpeed); 
    }

    public void UpdateSpeed(bool isRunning) => _isRunning = isRunning;
    #endregion
}
