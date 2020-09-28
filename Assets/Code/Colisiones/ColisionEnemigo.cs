using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColisionEnemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.name == "Moneda")
        {
            
        }
        else if (collision.gameObject.name == "Spike_Down")
        {
            
        }
        else if (collision.gameObject.name == "Model2-headInnerPiece-5-ForHead-9-4x (1)" || collision.gameObject.name == "Model2-headInnerPiece-5-ForHead-9-4x (2)")
        {
            Destroy(transform.parent.gameObject, 0.05f);
        }
        else
        {
            PuntajeManagerCoin.puntajeManagerCoin.RaiseScore(-100);
            Destroy(transform.parent.gameObject, 0.05f);

            SceneManager.LoadScene("Menu");

         
        }

    }


}
