using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.name == "EnemigoPiedra")
        {
            PuntajeManager.puntajeManager.RaiseScore(-1);
            Destroy(transform.parent.gameObject, 0.05f);
        }
        else if (collision.gameObject.name == "Coin") {

            PuntajeManager.puntajeManager.RaiseScore(5);
           Destroy(transform.parent.gameObject, 0.05f);

        }
        else
        {
            PuntajeManager.puntajeManager.RaiseScore(1);
          Destroy(transform.parent.gameObject,0.05f);
        }

        }
     
    }
