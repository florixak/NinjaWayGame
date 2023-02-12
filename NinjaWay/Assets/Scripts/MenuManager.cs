using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void StartStory()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Started game");
    }

    public void LoadStory()
    {
        SceneManager.LoadScene("Load");
        Debug.Log("Load game");
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("Settings");
        Debug.Log("Open settings");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }



}
