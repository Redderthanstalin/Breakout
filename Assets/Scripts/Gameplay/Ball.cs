using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A ball
/// </summary>
public class Ball : MonoBehaviour
{
    // move delay timer
    Timer moveTimer;

    // death timer
    Timer deathTimer;

    BallSpawner ballSpawner;

    //For Speedup Event
    //Timer speedupTimer;
    //bool isSpeedup = false;
    bool didSpeedup = false;
    Rigidbody2D rb2d;
    float speedupFactor;

	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // start move timer
        moveTimer = gameObject.AddComponent<Timer>();
        moveTimer.Duration = 1;
        moveTimer.Run();

        // start death timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = ConfigurationUtils.BallLifeSeconds;
        deathTimer.Run();

        //Find and store ball spawner
        ballSpawner = Camera.main.GetComponent<BallSpawner>();

        //EventManager.AddSpeedupEventlistener(SpeedupBall);

        rb2d = gameObject.GetComponent<Rigidbody2D>();
        //speedupTimer = gameObject.AddComponent<Timer>();

        Debug.Log(EffectUtils.IsSpeedup);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
	{

        // move when time is up
        if (moveTimer.Finished)
        {
            moveTimer.Stop();
            StartMoving();
        }

		// die when time is up
        if (deathTimer.Finished)
        {
            // spawn new ball and destroy self
            Camera.main.GetComponent<BallSpawner>().SpawnBall();
            Destroy(gameObject);
        }
	}

    void FixedUpdate()
    {
        if(EffectUtils.IsSpeedup && !didSpeedup)
        {
            float speed = rb2d.velocity.magnitude;
            rb2d.velocity = rb2d.velocity * (speed * 0.1f);
            didSpeedup = true;
        }
        else if(!EffectUtils.IsSpeedup && didSpeedup)
        {
            float speed = rb2d.velocity.magnitude;
            rb2d.velocity = rb2d.velocity * (speed * 0.5f);
            didSpeedup = true;
            didSpeedup = false;
        }

    }

    /// <summary>
    /// Spawn new ball and destroy self when out of game
    /// </summary>
    void OnBecameInvisible()
    {
        // death timer destruction is in Update
        if (!deathTimer.Finished)
        {
            // only spawn a new ball if below screen
            float halfColliderHeight = 
                gameObject.GetComponent<BoxCollider2D>().size.y / 2;
            if (transform.position.y - halfColliderHeight < ScreenUtils.ScreenBottom)
            {
                ballSpawner.SpawnBall();
                HUD.ReduceBallsLeft();
            }
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// Starts the ball moving
    /// </summary>
    void StartMoving()
    {
        if (EffectUtils.IsSpeedup)
        {
            // get the ball moving
            float angle = -90 * Mathf.Deg2Rad;
            Vector2 force = new Vector2(ConfigurationUtils.BallImpulseForce * Mathf.Cos(angle),ConfigurationUtils.BallImpulseForce * Mathf.Sin(angle));
            GetComponent<Rigidbody2D>().AddForce(force  * EffectUtils.SpeedupFactor);
        }else
        {
            // get the ball moving
            float angle = -90 * Mathf.Deg2Rad;
            Vector2 force = new Vector2(
                ConfigurationUtils.BallImpulseForce * Mathf.Cos(angle),
                ConfigurationUtils.BallImpulseForce * Mathf.Sin(angle));
            GetComponent<Rigidbody2D>().AddForce(force);
        }
        
        
    }

    /// <summary>
    /// Sets the ball direction to the given direction
    /// </summary>
    /// <param name="direction">direction</param>
    public void SetDirection(Vector2 direction)
    {
        // get current rigidbody speed
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        float speed = rb2d.velocity.magnitude;
        rb2d.velocity = direction * speed;
    }

    //public void SpeedupBall(float duration, float factor)
    //{
    //    if (EffectUtils.IsSpeedup)
    //    {
    //        speedupTimer.Duration += duration;
    //    }
    //    else
    //    {
    //        speedupTimer.Duration = duration;
    //        speedupTimer.Run();
    //        speedupFactor = factor;
    //        isSpeedup = true;   
    //    }
    //}
}