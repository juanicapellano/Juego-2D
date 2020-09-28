using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeManager : MonoBehaviour
{

    public static PuntajeManager puntajeManager;
    public Text scoreText;

    int score = 0;

    void Start()
    {
        puntajeManager = this;
    }

    public void RaiseScore(int s)
    {
        score += s;  
        scoreText.text = score.ToString();

    }

}
