using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D rb2d;
    BoxCollider2D coll;



	// Use this for initialization
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();

        Vector3 dir = Quaternion.AngleAxis(270, Vector3.forward) * Vector3.right;

        rb2d.AddForce(dir * ConfigurationUtils.BallImpulseForce);


	}
	
	public void SetDirection(Vector2 direction)
    {
        
        rb2d.velocity = direction * rb2d.velocity.magnitude;
    }
}
