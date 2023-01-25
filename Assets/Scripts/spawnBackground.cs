using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBackground : MonoBehaviour
{
    //Zmienne potrzebne do generowania t³a
    public GameObject bg;
    public Transform spawn;
    public float spawnRate = 7.0f;
    float timer = 0;

    void Update()
    {
        //Skrypt dodaje dalsze t³o co jakiœ czas
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else 
        {
            Instantiate(bg, spawn.position, spawn.rotation);
            timer = 0;
        }


    }
}
