﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusBlock : Block {

    
	// Use this for initialization
	void Start () {
        ScoreModifier = ConfigurationUtils.BonusBlockPoints;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
