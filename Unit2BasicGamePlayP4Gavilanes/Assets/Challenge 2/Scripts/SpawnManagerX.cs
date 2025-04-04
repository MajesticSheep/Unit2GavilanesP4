using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    //initialize the time that must pass before the spawn
    private float delayBeforeSpawn = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    private void Update()
    {
        //chekcing if our time to spawn ball is passed
        if(delayBeforeSpawn <=0)
        {
            //if true spawn a ball and generate a random time
            SpawnRandomBall();
            delayBeforeSpawn = Random.Range(3, 5);
        }
        else
        {
            //if false reducing the time before spawn. Using Time.deltaTime b/c it can simulate a real countdown
            delayBeforeSpawn -= Time.deltaTime;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
