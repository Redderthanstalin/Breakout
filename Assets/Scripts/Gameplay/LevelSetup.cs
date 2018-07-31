using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetup : MonoBehaviour {

    [SerializeField]
    GameObject[] Blocks;

    Vector3 startPos;

    float horziontalBuffer = 1.25f;
    float verticalBuffer = 0.5f;
    float ScreenZ;
    // Use this for initialization
	void Start () {
        ScreenZ = -Camera.main.transform.position.z;

        startPos = new Vector3(ScreenUtils.ScreenLeft + 0.75f, ScreenUtils.ScreenTop - verticalBuffer - 1, ScreenZ);

        PlaceBlocks();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlaceBlocks()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                Instantiate(Blocks[RandomPrefab()], startPos, Quaternion.identity);
                startPos.x += horziontalBuffer;
            }
            startPos.x = ScreenUtils.ScreenLeft + 0.75f;
            startPos.y -= verticalBuffer;
        }
    }

    int RandomPrefab()
    {
        int myNum = Random.Range(1, 21);
        if(myNum <= 14)
        {
            return 0;
        }else if(myNum >= 15 && myNum <= 18)
        {
            return 1;
        }
        else if(myNum == 19)
        {
            return 2;
        }
        else
        {
            return 3;
        }

    }
}
