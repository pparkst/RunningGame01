using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float ScrollSpeed = 0.5f;    //1)
    float Target_Offset;

    void Update()
    {
        Target_Offset += Time.deltaTime * ScrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Target_Offset, 0);
    }
}
