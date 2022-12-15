using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;
    public GameObject computerText;

    [Header("Computer")]
    public GameObject ComputerPaddle;
    public GameObject ComputerGoal;

    private int Player1score;
    private int Player2score;
   
    public void player1Scored()
    {
        Player1score++;
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1score.ToString();
        resetPosition();
    }
    public void player2Scored()
    {
        Player2score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = Player2score.ToString();
        resetPosition();
    }
    private void resetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
