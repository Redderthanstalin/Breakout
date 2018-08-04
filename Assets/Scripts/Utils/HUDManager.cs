using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    [SerializeField]
    Text ballsRemainingText;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    Text gameOverText;

	// Use this for initialization
	void Start () {
        gameOverText.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        ballsRemainingText.text = "Balls Remaining: " + GameManager.instance.TotalBalls;
        scoreText.text = "Score: " + GameManager.instance.TotalPoints;

        if(GameManager.instance.TotalBalls <= 0)
        {
            GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
            if(balls.Length == 0)
            {
                gameOverText.enabled = true;
            }
            
        }
	}
}
