using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    public static GameMode instance;

    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    public Text scoreText;
    public GameObject gameOverUI;

    int score = 0;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
		{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            score = 0;

        }
    }

    public void ScoreUp()
	{
        if (gameOver) return;

        score++;
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverUI.SetActive(true);
    }
}
