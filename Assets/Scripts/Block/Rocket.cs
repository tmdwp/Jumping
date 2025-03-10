using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] private float rocket;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CharacterManager.Instance.Player.GetComponent<Rigidbody>().AddForce(Vector2.up * rocket, ForceMode.Impulse);
        }
    }
}
