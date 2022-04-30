using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] Text scoreText1;
    [SerializeField] Text scoreText2;

    [SerializeField] BallControl ball;
    [SerializeField] int maxScore;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameOver over;
    

    int score1;
    int score2;

    private void Start()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        scoreText1.text = "" + score1;
        scoreText2.text = "" + score2;

        if(score1 >= maxScore)
        {
            over.FillText("Player 1 WIN");
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }else if (score2 >= maxScore)
        {
            over.FillText("Player 2 WIN");
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }

    }

    public void scoreIncrement(int index)
    {
        if (index == 1)
            score1++;
        else if(index == 2)
            score2++;
    }

}
