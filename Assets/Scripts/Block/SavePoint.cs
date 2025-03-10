using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    Transform savePoint;
    Vector3 savePosition;
    // Start is called before the first frame update
    void Start()
    {
        savePoint = transform.Find("SavePoint");

        if (savePoint != null)
        {
            savePosition = savePoint.position;
            //savePosition += transform.position;
        }
        else
        {
            Debug.Log("Child not found!");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterManager.Instance.Player.controller.GetSavePoint(savePosition);
        }
    }
}
