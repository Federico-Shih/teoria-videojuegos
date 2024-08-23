using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterJump : MonoBehaviour, IJumpable
{

    #region IJUMPABLE_PROPERTIES
    public Rigidbody Rb => _rb;

    public float JumpForce => _jumpForce;

    public bool IsGrounded => _isGrounded;

    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isGrounded;
    #endregion



    #region UNITY_EVENTS
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    #endregion


    #region IJUMPABLE_METHODS
    public void Jump()
    {
        // Usamos raycasting para decidir si colisionamos con el piso
        _isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.5f) ? true : false;


        if (_isGrounded) {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
    #endregion
}
