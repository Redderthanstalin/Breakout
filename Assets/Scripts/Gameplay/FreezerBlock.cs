using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FreezerBlock : Block {

    float effectDuration;

    //Hold the Unity Event for Freezing
    FreezerEffectActivatedEvent freezerEffectActivated = new FreezerEffectActivatedEvent();

	// Use this for initialization
	void Start () {
        ScoreModifier = ConfigurationUtils.FreezerBlockPoints;
        effectDuration = ConfigurationUtils.FreezeTime;

        EventManager.AddFreezeEventInvoker(this);        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddFreezeEffectlistener(UnityAction<float> listener)
    {
        freezerEffectActivated.AddListener(listener);
    }

    public override void OnCollisionEnter2D(Collision2D coll)
    {
        freezerEffectActivated.Invoke(effectDuration);
        base.OnCollisionEnter2D(coll);
    }
}
