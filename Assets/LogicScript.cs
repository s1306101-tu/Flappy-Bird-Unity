using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource gameOverMusic;
    public AudioSource gameMusic;


    void Start()
    {
        gameMusic.Play();
        scoreText.text = "score : " + playerScore.ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        Debug.Log("Adding +" + scoreToAdd + " score");
        playerScore += scoreToAdd;
        scoreText.text = "score : " + playerScore.ToString();
    }

    public void restartGame()
    {
        Debug.Log("Restart Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void gameOver()
    {
        if (!gameOverScreen.activeSelf)
        {
            //gameMusic.Stop();
            gameOverScreen.SetActive(true);
            //gameOverMusic.Play();
        }

    }
}
