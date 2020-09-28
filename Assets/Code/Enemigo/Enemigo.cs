using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public GameObject EnemigoPrefab;
    float randxP;
    float randyP;
    Vector2 spawnP;
    public float spawnrateP = 2f;
    float nextspawnP = 1.0f;

    void Update()
    {

        if (Time.time > nextspawnP)
        {
            nextspawnP = Time.time + spawnrateP;
            randxP = Random.Range(-17, 25);
            randyP = Random.Range(9, 10);
            spawnP = new Vector2(randxP, randyP);
            Instantiate(EnemigoPrefab, spawnP, Quaternion.identity);
        }

    }
}
