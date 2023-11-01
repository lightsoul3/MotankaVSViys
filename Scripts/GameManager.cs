using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseScreen;

    
    public void PlayGame() 
    {
        SceneManager.LoadScene("First Level");
    }

    public void RandomFromMenu()
    {
        string[] scenes = { "First Level", "Second Level", "Third Level", "Fourth Level", "Fifth Level" };
        int randomIndex = Random.Range(0, scenes.Length);
        SceneManager.LoadScene(scenes[randomIndex]);
    }



    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }



    public void NextFromFirstLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Second Level");
    }

    public void RandomFromFirstLevel()
    {
        Time.timeScale = 1f;
        string[] scenes = { "Second Level", "Third Level", "Fourth Level", "Fifth Level" };
        int randomIndex = Random.Range(0, scenes.Length);
        SceneManager.LoadScene(scenes[randomIndex]);
    }


    public void NextFromThirdLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fourth Level");
    }

    public void RandomFromThirdLevel()
    {
        Time.timeScale = 1f;
        string[] scenes = { "First Level", "Second Level", "Fourth Level", "Fifth Level" };
        int randomIndex = Random.Range(0, scenes.Length);
        SceneManager.LoadScene(scenes[randomIndex]);
    }


    public void NextFromSecondLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Third Level");
    }

    public void RandomFromSecondLevel()
    {
        Time.timeScale = 1f;
        string[] scenes = { "First Level", "Third Level", "Fourth Level", "Fifth Level" };
        int randomIndex = Random.Range(0, scenes.Length);
        SceneManager.LoadScene(scenes[randomIndex]);
    }


    public void NextFromFourthLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Fifth Level");
    }

    public void RandomFromFourthLevel()
    {
        Time.timeScale = 1f;
        string[] scenes = { "First Level", "Second Level", "Third Level", "Fifth Level" };
        int randomIndex = Random.Range(0, scenes.Length);
        SceneManager.LoadScene(scenes[randomIndex]);
    }


    public void NextFromFifthLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("First Level");
    }

    public void RandomFromFifthLevel()
    {
        Time.timeScale = 1f;
        string[] scenes = { "First Level", "Second Level", "Third Level", "Fourth Level" };
        int randomIndex = Random.Range(0, scenes.Length);
        SceneManager.LoadScene(scenes[randomIndex]);
    }



}
