using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// A pickup block
/// </summary>
public class PickupBlock : Block
{
    [SerializeField]
    Sprite freezerSprite;
    [SerializeField]
    Sprite speedupSprite;

    PickupEffect effect;

    float effectDuration;
    float speedupFactor;

    FreezerEffectActivated freezerEventActivated = new FreezerEffectActivated();
    SpeedupEffectActivated speedupEventActivated = new SpeedupEffectActivated();

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // set points
        points = ConfigurationUtils.PickupBlockPoints;
        effectDuration = ConfigurationUtils.EffectDuration;
        speedupFactor = 2f;

        if(this.effect == PickupEffect.Freezer)
        {
            EventManager.AddFreezerEventInvoker(this);
        }else
        {
            EventManager.AddSpeedupEventInvoker(this);
        }
        
    }
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        
    }

	/// <summary>
    /// Sets the effect for the pickup
    /// </summary>
    /// <value>pickup effect</value>
    public PickupEffect Effect
    {
        set
        {
            effect = value;
            // set sprite
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (effect == PickupEffect.Freezer)
            {
                spriteRenderer.sprite = freezerSprite;
                
            }
            else
            {
                spriteRenderer.sprite = speedupSprite;
            }
        }
    }

    public void AddFreezerEffectListener(UnityAction<float> listener)
    {
        freezerEventActivated.AddListener(listener);
    }

    public void AddSpeedupEffectListener(UnityAction<float, float> listener)
    {
        speedupEventActivated.AddListener(listener);
    }

    protected override void OnCollisionEnter2D(Collision2D coll)
    {
        freezerEventActivated.Invoke(effectDuration);
        speedupEventActivated.Invoke(effectDuration, speedupFactor);
        base.OnCollisionEnter2D(coll);
    }
}
