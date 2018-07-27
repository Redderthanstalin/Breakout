﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }
}