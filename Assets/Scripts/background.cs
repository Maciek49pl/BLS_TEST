using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    private float speed = 0.2f;

    void Update()
    {
        //T�o przesuwa si� ze sta�� pr�dko�ci� a je�li wyjdzie poza widok kamery to si� usuwa
        transform.position = transform.position + (Vector3.left * speed * Time.fixedDeltaTime);
        if (transform.position.x < -45)
        {
            Destroy(gameObject);
        }
    }
}
