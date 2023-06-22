using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void WinSceneLoad()
    {
        SceneManager.LoadScene(1);
    }

    public void LoseSceneLoad()
    {
        SceneManager.LoadScene(2);
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}
