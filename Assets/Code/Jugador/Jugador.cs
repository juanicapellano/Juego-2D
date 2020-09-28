using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour

{

    bool Canjum;
    void Start()
    {
    }
  public GameObject particle;
    void Update()

    {

        if (Input.GetKey("left") )
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("parMoving",true);
           
            

        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(300f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("parMoving", true);
            
        
        }


        if (!Input.GetKey("left")  && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("parMoving", false);
        }

        if (Input.GetKeyDown("space") && Canjum)
        {
            Canjum = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 70f));
            gameObject.GetComponent<Animator>().SetBool("parJump", true);



        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground")
        {
            Canjum = true;

            gameObject.GetComponent<Animator>().SetBool("parJump", false) ;
        }

    }

   

}
