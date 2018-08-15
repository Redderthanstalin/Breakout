using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class MenuManager {

    public static MenuName menuName = MenuName.Pause;

    public static GameObject mainMenuCanvas;

    public static void GoToMenu(MenuName name)
    {
        switch (name)
        {
            case MenuName.Gameplay:
                SceneManager.LoadScene("Gameplay");
                break;
            case MenuName.MainMenu:
                SceneManager.LoadScene("MainMenu");
                break;
            case MenuName.Help:
                mainMenuCanvas = GameObject.Find("MainMenuCanvas");
                mainMenuCanvas.SetActive(false);

                Object.Instantiate(Resources.Load("HelpMenu"));
                break;
            case MenuName.Pause:
                Object.Instantiate(Resources.Load("PauseMenu"));
                break;
        }

            
    }
}
