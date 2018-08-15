using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMenu : MonoBehaviour {

	public void HandleBackButtonOnClickEvent()
    {
        MenuManager.mainMenuCanvas.SetActive(true);
        Destroy(gameObject);
    }
}
