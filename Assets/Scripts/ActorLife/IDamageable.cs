using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    float Life { get; }
    float CurrentLife { get; }

    void TakeDamage(float damage);
    void RestoreLife(float amount);
    void Die();
}
