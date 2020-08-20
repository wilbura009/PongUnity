using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")] public GameObject ball;

    [Header("Player1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int _player1Score;
    private int _player2Score;

    public void Player1Scored()
    {
        ++_player1Score;
        player1Text.GetComponent<TextMeshProUGUI>().text = _player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        ++_player2Score;
        player2Text.GetComponent<TextMeshProUGUI>().text = _player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
}
