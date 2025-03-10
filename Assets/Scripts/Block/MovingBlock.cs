using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Way
{
    TopDown,
    LeftRight
}

public class MovingBlock : MonoBehaviour
{
    Vector3 startPositon;
    // Start is called before the first frame update
    void Start()
    {
        startPositon = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
