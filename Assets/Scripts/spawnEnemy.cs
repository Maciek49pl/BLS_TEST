using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    //Dane dla ró¿nych punktów spawnów
    public GameObject enemy;
    public Transform spawn0;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;

    //czêstotliwoœæ spawnu 
    public float spawnRate = 5.0f;
    float timer = 0;

    void Update()
    {
        //Odliczanie czasu...
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            //Gdy czas mija to skrypt tworzy losow¹ liczbê wrogów od 2 do 5 i rozprowadza ich po miejscach odrodzenia
            float randomSpawn = Random.Range(2, 5);

            for (float i = 0; i < randomSpawn; i++)
            {
                float randomPlace = Random.Range(0, 4);
                if (randomPlace == 0)
                {
                    Instantiate(enemy, spawn0.position, spawn0.rotation);
                    timer = 0;
                }

                if (randomPlace == 1)
                {
                    Instantiate(enemy, spawn1.position, spawn1.rotation);
                    timer = 0;
                }

                if (randomPlace == 2)
                {
                    Instantiate(enemy, spawn2.position, spawn2.rotation);
                    timer = 0;
                }

                if (randomPlace == 3)
                {
                    Instantiate(enemy, spawn3.position, spawn3.rotation);
                    timer = 0;
                }

                if (randomPlace == 4)
                {
                    Instantiate(enemy, spawn4.position, spawn4.rotation);
                    timer = 0;
                }
            }
        }
    }
}
