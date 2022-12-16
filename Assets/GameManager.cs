using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int jeffScore;
    public Text scoreText;
    public GameObject ggBtns;

    [ContextMenu("Jeff Score")]
    public void AddScore()
    {
        jeffScore++;
        scoreText.text = jeffScore.ToString();
    }
    public void GameOver()
    {
        ggBtns.SetActive(true);
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ggBtns.SetActive(false);
    }


    public void GameEnd()
    {
        Application.Quit();
    }
}
