using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterLife : MonoBehaviour, IDamageable
{

    [SerializeField] private float _life;
    public float Life => _life;

    [SerializeField] private float _currentLife;
    public float CurrentLife => _currentLife;


    #region IDAMAGEABLE_METHODS

    public void Die()
    {
        // Destruyo el objeto 
        Destroy(gameObject);
    }

    public void RestoreLife(float amount)
    {
        _currentLife += amount;

        if (_currentLife > _life) {
            _currentLife = _life;
        }
    }

    public void TakeDamage(float damage)
    {
        _currentLife -= damage;

        if (_currentLife <= 0)   Die();

    }
    #endregion

    #region UNITY_EVENTS
    // Start is called before the first frame update
    void Start()
    {
        _currentLife = _life;
    }
    #endregion
}