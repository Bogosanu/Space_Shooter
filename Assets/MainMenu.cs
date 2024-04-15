using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    void Start()
    {
        Application.targetFrameRate = 55;
        QualitySettings.vSyncCount = 0;
    }

    public void PlayGame ()
    {
        SceneManager.LoadScene("Level1");
    }

    public void PlayEndless ()
    {
        SceneManager.LoadScene("Endless_Mode");
    }


    public void QuitGame ()
    {
        Application.Quit();
    }

    public void BackToMenu ()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
