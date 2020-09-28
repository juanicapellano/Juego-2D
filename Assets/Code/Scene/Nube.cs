using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube : MonoBehaviour
{
    float speed = 1f;
    Vector3 StartPosition;
    float x;
    float y;
    void Start()
    {
        StartPosition = transform.position;
    }
        void Update()
        {
        float newpos = Mathf.Repeat(Time.time * speed, 60);
        transform.position = StartPosition + Vector3.right * newpos;
        }
}