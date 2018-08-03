using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    protected int ScoreModifier;

    void Start()
    {
        ScoreModifier = ConfigurationUtils.StandardBlockPoints;
    }

    public void AddScore()
    {
        GameManager.instance.AddPoints(ScoreModifier);
    }

	public virtual void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ball")
        {
            AddScore();
            Destroy(gameObject);
        }
    }
}
