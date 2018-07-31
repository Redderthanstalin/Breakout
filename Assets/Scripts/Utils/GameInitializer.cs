using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initializes the game
/// </summary>
public class GameInitializer : MonoBehaviour
{

    public GameObject gameManager;

    /// <summary>
    /// Awake is called before Start
    /// </summary>
	void Awake()
    {
        if (GameManager.instance == null)

            //Instantiate gameManager prefab
            Instantiate(gameManager);

        // initialize screen utils
        ScreenUtils.Initialize();
        ConfigurationUtils.Initialize();

    }
}
