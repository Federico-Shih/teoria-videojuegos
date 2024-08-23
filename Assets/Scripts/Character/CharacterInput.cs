using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    #region PROPERTIES
    private CharacterMovement _characterMovement;
    private CharacterJump _jumpLogic;
    private CharacterLife _lifeLogic;

    #endregion

    #region KEY_MAPPING
    [SerializeField] private KeyCode _moveForward = KeyCode.W;
    [SerializeField] private KeyCode _moveBack = KeyCode.S;
    [SerializeField] private KeyCode _moveLeft = KeyCode.A;
    [SerializeField] private KeyCode _moveRight = KeyCode.D;

    [SerializeField] private KeyCode _walkRun = KeyCode.LeftShift;
    [SerializeField] private KeyCode _jump = KeyCode.Space;

    [SerializeField] private KeyCode _takeDamage = KeyCode.F1;
    [SerializeField] private KeyCode _restoreLife = KeyCode.F2;

    #endregion


    #region UNITY_EVENTS
    // Start is called before the first frame update
    void Start()
    {
        _characterMovement = GetComponent<CharacterMovement>();
        _jumpLogic = GetComponent<CharacterJump>();
        _lifeLogic = GetComponent<CharacterLife>();
    }



    // Update is called once per frame
    void Update()
    {
        // Movement
        if (Input.GetKey(_moveForward)) _characterMovement.Move(transform.forward);
        if (Input.GetKey(_moveBack)) _characterMovement.Move(-transform.forward);
        if (Input.GetKey(_moveLeft)) _characterMovement.Move(-transform.right);
        if (Input.GetKey(_moveRight)) _characterMovement.Move(transform.right);

        // Acivate run
        if (Input.GetKeyDown(_walkRun)) _characterMovement.UpdateSpeed(true);
        if (Input.GetKeyUp(_walkRun)) _characterMovement.UpdateSpeed(false);

        // Salto
        if (Input.GetKeyDown(_jump)) _jumpLogic.Jump();


        // Vida manopla
        if (Input.GetKeyDown(_takeDamage)) _lifeLogic.TakeDamage(10f);
        if (Input.GetKeyDown(_restoreLife)) _lifeLogic.RestoreLife(5f);

    }
    #endregion
}
