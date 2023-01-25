using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    //definiuje zmienn� highscore
    private float highScore;
    public Text HighScoreWrite;

    void Start()
    {
        //Pobiera dane z "Highscore" a nast�pnie wprowadza go na ekran
        highScore =  PlayerPrefs.GetFloat("Highscore", 0);
        HighScoreWrite.text = highScore.ToString();
    }

    void Update()
    {
        //Kliknij dowolny przycisk i zaczynaj gr�
        if(Input.anyKey)
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
