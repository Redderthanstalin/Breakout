using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


    [SerializeField]
    BallSpawner ballSpawner;

    //Used to determine the Lifespan of the ball
    float ballLifeSpan = 20;

    //stored refence to the Rigidbody 
    Rigidbody2D rb2d;

    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;

    //Direction the ball will move after spawning
    Vector3 dir;


    //Set a random position for the ball to spawn at
    Vector3 spawnPosition;



	// Use this for initialization
	void Start () {

        ballSpawner = ballSpawner.GetComponent<BallSpawner>();

        rb2d = gameObject.GetComponent<Rigidbody2D>();

        dir = Quaternion.AngleAxis(Random.Range(200, 340), Vector3.forward) * Vector3.right;

        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_NewColor = new Color(Random.value, Random.value, Random.value, 1f);

        m_SpriteRenderer.color = m_NewColor;

        spawnPosition = new Vector3();
        spawnPosition.x = Random.Range(ScreenUtils.ScreenLeft, ScreenUtils.ScreenRight);
        spawnPosition.y = Random.Range(0, 1);
        spawnPosition.z = -Camera.main.transform.position.z;

        StartCoroutine(DelayMove());
        StartCoroutine(alphaFade(1.0f, ballLifeSpan));
        StartCoroutine(DeathTime());

        
	}



    IEnumerator DelayMove()
    {
        yield return new WaitForSeconds(1);
        rb2d.AddForce(dir * ConfigurationUtils.BallImpulseForce);

    }

    IEnumerator DeathTime()
    {
        while (GameManager.instance.TotalBalls > 0)
        {
            yield return new WaitForSeconds(ballLifeSpan);
            Destroy(gameObject);
            ballSpawner.SpawnNewBall();
        }
  
    }

    //Make the ball slowly fade out during it's lifetime for player feedback
    IEnumerator alphaFade(float aValue, float aTime)
    {
        float alpha = m_NewColor.a;
        for(float t = 1.0f; t > 0.0f; t -= Time.deltaTime / aTime)
        {
            Color newcolor = new Color(m_NewColor.r, m_NewColor.g, m_NewColor.b, t);
            m_SpriteRenderer.color = newcolor;
            yield return null;
        }
        
    }
	
	public void SetDirection(Vector2 direction)
    {
        
        rb2d.velocity = direction * rb2d.velocity.magnitude;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
        ballSpawner.SpawnNewBall();
    }

    void OnApplicationQuit()
    {
        Destroy(this.gameObject);
    }
}
