using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    private float speed = 0.2f;

    void Update()
    {
        //T³o przesuwa siê ze sta³¹ prêdkoœci¹ a jeœli wyjdzie poza widok kamery to siê usuwa
        transform.position = transform.position + (Vector3.left * speed * Time.fixedDeltaTime);
        if (transform.position.x < -45)
        {
            Destroy(gameObject);
        }
    }
}
