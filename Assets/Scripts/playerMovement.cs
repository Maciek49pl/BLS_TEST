using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    //Zmienne 
    public float speed;
    public float hp = 5;
    private float points;
    private float highScore;
    public float time = 100;

    //Liczniki ¿yæ, punktów oraz czasu
    public Text hpText;
    public Text pointsText;
    public Text timeText;

    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Odczytywanie klawiszy z klawiatury
        movement.y = Input.GetAxisRaw("Vertical");

        //Przenoszenie zmiennych na liczniki
        time = time - Time.deltaTime;
        hpText.text = hp.ToString();
        timeText.text = time.ToString();

        //Koniec gry. Jeœli obecny wynik jest mniejszy ni¿ obecny rekord to nie nadpisze rekordu
        if (hp < 1 || time < 1)
        {
            highScore = PlayerPrefs.GetFloat("Highscore", 0);

            if (points > highScore)
            {
                PlayerPrefs.SetFloat("Highscore", points);
            }
            SceneManager.LoadScene("StartGame");
        }
    }
    //Funkcja dodawania punktów
    public void addScore(int scoreToAdd)
    {
        points = points + scoreToAdd;
        pointsText.text = points.ToString();
    }

    //Poruszanie siê samolotu
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
    //W momencie kolizji z wrogim samolotem gracz traci hp
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            hp = hp - 1;
        }
    }
}