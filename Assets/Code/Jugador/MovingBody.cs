using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBody : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {

        if (Input.GetKey("left"))
        {
            
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
           
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

    }
}
