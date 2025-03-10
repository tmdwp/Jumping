using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VendingMachine : MonoBehaviour, IInteractable
{
    public ItemData machine;
    public ItemData[] data;
    string str;
    public string GetInteractPrompt()
    {
        str = $"{machine.displayName}\n{machine.description}";
        return str;
    }

    public void OnInteract()
    {
        int rand = Random.Range(0, data.Length);
        Instantiate(data[rand].dropPrefab, transform.position + Vector3.left +Vector3.up, Quaternion.identity);
    }
}
