using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public static float score = 0;


    private void Update()
    {
        scoreText.text = "SCORE " + Mathf.Round(score);
    }

    public void GameOver ()
    {
        
        SceneManager.LoadScene("Game_Over");
    }

    public void Victory ()
    {
        score = 0;
        SceneManager.LoadScene("Victory");
    }
}
