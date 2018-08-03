using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    [SerializeField]
    GameObject ballPrefab;

    IEnumerator Ballspawning;

    int minSpawn; 
    int maxSpawn;

    float ScreenZ;

    float Timer;

	// Use this for initialization
	void Start () {

        //Ballspawning = BallSpawn(Random.Range(minSpawn, maxSpawn));
        //StartCoroutine(Ballspawning);

        minSpawn = ConfigurationUtils.MinSpawnTime;
        maxSpawn = ConfigurationUtils.MaxSpawnTime;

        ScreenZ = -Camera.main.transform.position.z;

        Timer = Time.time + 1;

    }
	
    void Update()
    {
        if(Timer < Time.time)
        {
            SpawnNewBall();
            Timer = Time.time + Random.Range(minSpawn, maxSpawn);
        }
    }

    //IEnumerator BallSpawn(float waitTime)
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(waitTime);
            
    //    }
        
   
    //}

    public void SpawnNewBall()
    {
        if(GameManager.instance.TotalBalls > 0)
        {
            Instantiate(ballPrefab, RandomRangeVec(), Quaternion.identity);
            GameManager.instance.RemoveBall();
        }
        
    }



    Vector3 RandomRangeVec()
    {
        Vector3 position = new Vector3();
        position.x = Random.Range(ScreenUtils.ScreenLeft, ScreenUtils.ScreenRight);
        position.y = Random.Range(0, 1);
        position.z = ScreenZ;
        return position;
    }
}
