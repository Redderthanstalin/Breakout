using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedupEffectMonitor : MonoBehaviour {

    Timer speedupTimer;
    bool isSpeedup = false;

    float speedupFactor;

    public bool IsSpeedup
    {
        get { return isSpeedup; }
    }

    public float SpeedupFactor
    {
        get { return speedupFactor; }
    }

    public float Duration
    {
        get { return speedupTimer.Duration; }
    }


	// Use this for initialization
	void Start () {
        speedupTimer = gameObject.AddComponent<Timer>();

        speedupFactor = 2f;

        EventManager.AddSpeedupEventlistener(SpeedupEvent);
	}
	
	// Update is called once per frame
	void Update () {

        if (speedupTimer.Finished)
        {
            isSpeedup = false;
        }
	}

    void SpeedupEvent(float duration, float factor)
    {
        if (isSpeedup)
        {
            speedupTimer.Duration += duration;
        }
        else
        {
            speedupTimer.Duration = duration;
            speedupTimer.Run();
            speedupFactor = factor;
            isSpeedup = true;
        }
    }
}
