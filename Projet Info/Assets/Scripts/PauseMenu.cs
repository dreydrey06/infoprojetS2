using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject GameModeUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        	if (GameIsPaused)
        	{
        		Resume();
        	}
        	else 
        	{
        		Pause();
        	}
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        GameModeUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        GameModeUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
