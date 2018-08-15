using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public void HandleResumeButtonOnClick()
    {
        Time.timeScale = 1;
        GameObject pausePanel = GameObject.Find("PausePanel");
        pausePanel.SetActive(false);
        Destroy(gameObject);
    }

    public void HandleQuitButtonOnClick()
    {
        Application.Quit();
    }
}
