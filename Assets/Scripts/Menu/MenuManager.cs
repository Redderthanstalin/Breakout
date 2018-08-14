using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class MenuManager {

    public static MenuName menuName = MenuName.Pause;

    public static void GoToMenu()
    {
        switch (menuName)
        {
            case MenuName.Gameplay:
                break;
            case MenuName.MainMenu:
                break;
            case MenuName.Help:
                break;
            case MenuName.Pause:
                break;
        }

            
    }
}
