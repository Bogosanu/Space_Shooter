using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class death_manager : MonoBehaviour
{
    public Text scoreText;
    void Start()
    {
        scoreText.text = "FINAL SCORE: "  + Mathf.Round(GameManager.score);
        GameManager.score = 0;
    }

   
}
