using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject newBestCanvas;
    public GameObject medalCanvas;

    public MedalHandler medalHandler;

    private void Start()
    {
        startCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        scoreCanvas.SetActive(false);
        newBestCanvas.SetActive(false);
        medalCanvas.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;

        // Store highscore
        if (!PlayerPrefs.HasKey("bestScore"))
        {
            PlayerPrefs.SetInt("bestScore", 0);
        }
        if (Score.score > PlayerPrefs.GetInt("bestScore"))
        {
            PlayerPrefs.SetInt("bestScore", Score.score);
            newBestCanvas.SetActive(true);
        }

        // Set medal sparkles
        if (Score.score >= 5)
        {
            medalCanvas.SetActive(true);
        }
        else
        {
            medalCanvas.SetActive(false);
        }

        // Check what medal needs to be displayed
        if (Score.score < 5)
        {
            medalHandler.SetMedal(0);
            medalCanvas.SetActive(false);
        }
        else if (Score.score >= 5 && Score.score < 10)
        {
            medalHandler.SetMedal(1);
            medalCanvas.SetActive(true);
        }
        else if (Score.score >= 10 && Score.score < 25)
        {
            medalHandler.SetMedal(2);
            medalCanvas.SetActive(true);
        }
        else if (Score.score >= 25 && Score.score < 50)
        {
            medalHandler.SetMedal(3);
            medalCanvas.SetActive(true);
        }
        else if (Score.score >= 50)
        {
            medalHandler.SetMedal(4);
            medalCanvas.SetActive(true);
        }

        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        startCanvas.SetActive(false);
        scoreCanvas.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
