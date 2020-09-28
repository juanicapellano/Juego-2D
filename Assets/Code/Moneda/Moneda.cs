using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public GameObject MonedaPrefab;


    float randx;
    float randy;
    Vector2 spawn;
    float nextspawn = 1f; //Tiempo en el que se genera el siguiente spawn de la moneda original


    void Update()
    {
        if (Time.time > nextspawn)
        {
            nextspawn = Time.time + 10; //Spawn Rate
            randx = Random.Range(-27, 6);  // Coordenadas x
            randy = Random.Range(14, 15);  // Coordenadas y
            spawn = new Vector2(randx, randy);
            Instantiate(MonedaPrefab, spawn, Quaternion.identity);
        }

    }

}
