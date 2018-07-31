using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    int totalBalls = 10;

    int totalPoints = 0;


    public int TotalBalls
    {
        get { return totalBalls; }

    }

    public int TotalPoints
    {
        get { return totalPoints; }
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
        totalBalls = ConfigurationUtils.TotalBalls;
	}
	
	// Update is called once per frame
	public void AddPoints (int amount) {
        totalPoints += amount;
	}

    public void RemoveBall()
    {
        totalBalls -= 1;
    }
}
