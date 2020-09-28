using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuntajeManagerCoin : MonoBehaviour
{

    public static PuntajeManagerCoin puntajeManagerCoin;
    public Text scoreText;

    int score = 0;

    void Start()
    {
        puntajeManagerCoin = this;
    }

    public void RaiseScore(int s)
    {
        score += s;
        scoreText.text = score.ToString();


        if (score == 10)
        {
            SceneManager.LoadScene("Final");
        }

    }

}
