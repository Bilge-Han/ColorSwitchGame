using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerInGame : MonoBehaviour
{
    public GameObject inGameScreen, gameOverScreen, top, cember;
    public Text scoreText, score;
    // Start is called before the first frame update
    public void GameOverManage()
    {
        scoreText.text = " Your Score " + score.text;
        Time.timeScale = 0;
        top.SetActive(false);
        cember.SetActive(false);
        inGameScreen.SetActive(false);
        gameOverScreen.SetActive(true);
    }
    public void HomeButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void RetryButton()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
 