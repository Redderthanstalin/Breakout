using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Paddle : MonoBehaviour {

    //used to move the paddle
    Rigidbody2D rb2d;
    //Using this to determine the speed of the Paddle
    Vector2 direction;

    BoxCollider2D coll;
    //Used to store the half width of the paddle to make sure we don't go off screen.
    float halfWidth;

    //Tracking items for the Freeze Method
    Timer freezeTimer;
    bool isFrozen = false;

    //Used to create a 'curved' paddle to make the game more interesting.
    const float BounceAngleHalfRange = 45f;

    // Use this for initialization
    void Start () {

        rb2d = gameObject.GetComponent<Rigidbody2D>();
        direction = new Vector2(ConfigurationUtils.PaddleMoveUnitsPerSecond, 0f);
        
        //Initialize and get a reference to the box collider
        coll = gameObject.GetComponent<BoxCollider2D>();
        halfWidth = coll.size.x;

        EventManager.AddFreezeEventListener(FreezerEffectActivated);

        freezeTimer = gameObject.AddComponent<Timer>();

	}

    void Update()
    {
        if (freezeTimer.Finished)
        {
            isFrozen = false;
            
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        float HorizontalInput = Input.GetAxis("Horizontal");

        if(HorizontalInput != 0 && isFrozen == false)
        {
            float ClampedX = CalculateClampedX(rb2d.position.x + direction.x * HorizontalInput * Time.fixedDeltaTime);
            rb2d.MovePosition(new Vector2(ClampedX, rb2d.position.y));
        }
        
	}

    float CalculateClampedX(float newX)
    {
        if(newX >= ScreenUtils.ScreenRight - halfWidth)
        {
            return ScreenUtils.ScreenRight - halfWidth;
        }
        else if(newX <= ScreenUtils.ScreenLeft + halfWidth)
        {
            return ScreenUtils.ScreenLeft + halfWidth;
        }
        else
        {
            return newX;
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Ball" && IsTopCollision(coll.collider))
        {
            
            // calculate new ball direction
            float ballOffsetFromPaddleCenter = transform.position.x - coll.transform.position.x;
            float normalizedBallOffset = ballOffsetFromPaddleCenter / halfWidth;
            float angleOffset = normalizedBallOffset * BounceAngleHalfRange;
            float angle = Mathf.PI / 2 + angleOffset;
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

            // tell ball to set direction to new direction
            Ball ballScript = coll.gameObject.GetComponent<Ball>();
            ballScript.SetDirection(direction);
        }
    }

    bool IsTopCollision(Collider2D coll)
    {
        if (coll.transform.position.y > -4)
        {
            return true;
        }
        return false;
    }

    void FreezerEffectActivated(float time)
    {
        if (freezeTimer.Running)
        {
            freezeTimer.Duration += time;
        }else
        {
            freezeTimer.Duration = time;
            freezeTimer.Run();
            isFrozen = true;
        }
        
    }
}
