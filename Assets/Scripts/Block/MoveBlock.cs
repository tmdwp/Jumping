using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    public MovingBlock setting;
    public Vector3 setMove;
    Vector3 move;
    Rigidbody body;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        switch (setting.way)
        {
            case Way.FB:
                setMove = Vector3.forward;
                break;
            case Way.LR:
                setMove = Vector3.left;
                break;
            case Way.TD:
                setMove = Vector3.up;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        move = setMove * setting.speed * Time.deltaTime;
        body.position += move;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            setMove *= -1f;
        }
    }
}
