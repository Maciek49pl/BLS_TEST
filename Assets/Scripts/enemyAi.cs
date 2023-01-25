using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAi : MonoBehaviour
{
    //definiuje prêdkoœæ samolotu
    public float speed = 1f;

    public playerMovement points;

    void Start()
    {
        points = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
    }

    void Update()
    {
        //samolot porusza siê stale w lewo
        transform.position = transform.position + (Vector3.left * speed * Time.fixedDeltaTime);

        //Gdy odleci poza widok kamery to znika
        if (transform.position.x < -45)
        {
            Destroy(gameObject);
        }
    }
    //Podczas kolizji z pociskiem gracza samolot wraz z pociskiem znika i zalicza nam punkty
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Bullet")
        {
            points.addScore(2);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
