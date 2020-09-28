using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Reiniciar : MonoBehaviour
{

    private float tim;


   private void OnBecameInvisible() {
        SceneManager.LoadScene("Menu");
  }


}