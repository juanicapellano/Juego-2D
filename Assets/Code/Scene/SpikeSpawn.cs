using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawn : MonoBehaviour
{
    float timer;
    public GameObject spikePrefab;
    void Update()
    {
        timer += Time.deltaTime;
         if(timer >= 2f)
        {
            timer = 0;
            float x = Random.Range(-20.67f, 1.76f);
            Vector3 position = new Vector3(x, 1.04f, 0);
            Quaternion rotation = new Quaternion();
           
            Instantiate(spikePrefab, position,rotation);
        }
    }
}
