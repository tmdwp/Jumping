using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    void TakePhysicalDamage(int damage);
}

public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }
    Condition stamina { get { return uiCondition.stamina; } }

    public event Action onTakeDamage;

    // Update is called once per frame
    void Update()
    {
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Die!");
        Time.timeScale = 0f;
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }


    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage?.Invoke();
    }

    public bool UseStamina(float amount)
    {
        if(stamina.curValue - amount < 0)
        {
            return false;
        }

        stamina.Subtract(amount);
        return true;
    }

    public bool CheckUseStamina(float amount)
    {
        if(amount < stamina.curValue)
            return true;
        return false;
    }
}
