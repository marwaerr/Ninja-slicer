using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoremanager : MonoBehaviour
{
    public static Scoremanager instance;
    public TMP_Text scoreText;
    public TMP_Text highscoreText;
    

    public int score = 0;
    int highScore=0;
   

    void Awake() { 
    instance =this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore= PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = score.ToString() + "POINTS";
        highscoreText.text = "HIGHSCORE: "+highScore.ToString();


    }

    // Update is called once per frame
    public void AddPoint()
    {
        
        score += 1;
            scoreText.text = score.ToString() + "POINTS";
        if (highScore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
    public void DelPoint()
    {

        score -= 10;
        scoreText.text = score.ToString() + "POINTS";
        if (highScore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        if (score < 0)
        {
            score = 0;
            FindObjectOfType<GameManager>().Endgame(score);
        }
    }
}



