using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private string LevelName;
    [SerializeField]
    private GameObject PauseGame;
    [SerializeField]
    private string ResetCena;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GamePause();
        }
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(LevelName);
        Debug.Log("Game Started!");
    }

    public void GamePause()
    {
        PauseGame.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        PauseGame.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Quit()
    {
        Debug.Log("Game Closed!");
        Application.Quit();
    }
}
