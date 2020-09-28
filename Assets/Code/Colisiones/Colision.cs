using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.name == "EnemigoPiedra")
        {
            PuntajeManagerCoin.puntajeManagerCoin.RaiseScore(0);
            Destroy(transform.parent.gameObject, 0.05f);
        }
        else if (collision.gameObject.name == "Spike_Down") {
            PuntajeManagerCoin.puntajeManagerCoin.RaiseScore(0);
            Destroy(transform.parent.gameObject, 0.05f);

}
        else if (collision.gameObject.name == "Model2-headInnerPiece-5-ForHead-9-4x (1)" || collision.gameObject.name == "Model2-headInnerPiece-5-ForHead-9-4x (2)")
        {
            PuntajeManagerCoin.puntajeManagerCoin.RaiseScore(0);
            Destroy(transform.parent.gameObject, 0.05f);

        }
        else
        {
            PuntajeManagerCoin.puntajeManagerCoin.RaiseScore(1);
            Destroy(transform.parent.gameObject, 0.05f);
        }

        }

    }
