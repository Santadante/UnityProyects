using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float speed = 3.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
