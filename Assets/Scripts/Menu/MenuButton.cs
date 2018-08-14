using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour {

    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("If it was a build, this appliation would be dead right now.");
    }
}
