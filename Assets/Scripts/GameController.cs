using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;

    public static GameController instance;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText() {
        if(totalScore >= 10 && totalScore <= 90) {
            scoreText.text = "00" + totalScore.ToString();
        } else if(totalScore >= 100 && totalScore <= 900) {
            scoreText.text = "0" + totalScore.ToString();
        } else {
            scoreText.text = totalScore.ToString();
        }
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvl_name)
    {
        SceneManager.LoadScene(lvl_name);
    }
}
