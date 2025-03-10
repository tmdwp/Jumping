using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public int damage;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out IDamagable damagable))
        {
            CharacterManager.Instance.Player.condition.TakePhysicalDamage(damage);
            CharacterManager.Instance.Player.controller.GoToSave();
        }
    }
}
