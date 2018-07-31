using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    [SerializeField]
    GameObject ballPrefab;

    IEnumerator Ballspawning;

	// Use this for initialization
	void Start () {

        Ballspawning = BallSpawn(Random.Range(5, 10));
        StartCoroutine(Ballspawning);

        Debug.Log("Hey, I'm here!");
        Debug.Log(GameManager.instance.TotalBalls > 0);

	}
	


    IEnumerator BallSpawn(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        SpawnNewBall();
   
    }

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
        position.z = -Camera.main.transform.position.z;
        return position;
    }
}
