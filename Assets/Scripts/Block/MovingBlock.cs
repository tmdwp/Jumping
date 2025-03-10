using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Way
{
    TD, //TopDown
    LR, //LeftRight
    FB //FrontBack
}

[CreateAssetMenu(fileName = "MovingBlock", menuName = "New MovingBlcok")]
public class MovingBlock : ScriptableObject
{
    [Header("Info")]
    Vector3 startPositon;
    public float speed;
    public Way way;
}
