using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public void HandlePlayButtonOnClickEvent()
    {
        MenuManager.GoToMenu(MenuName.Gameplay);
    }

    public void HandleQuitButtonOnClickEvent()
    {
        Application.Quit();
    }

    public void HandleHelpButtonOnClickEvent()
    {
        MenuManager.GoToMenu(MenuName.Help);
    }
}
