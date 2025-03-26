using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerHorizontal : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnSideX = 20;
    private float spawnSideZ = 15;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("sideSpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void sideSpawnRandomAnimal ()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //animals going right
        Vector3 rotationRight = new Vector3(0, 90, 0);

        //animals going left
        Vector3 rotationLeft = new Vector3(0, 270, 0);

        //Range of animal spawn on right
        Vector3 spawnrightPosition = new Vector3(spawnSideX, 0, Random.Range(0, spawnSideZ));

        //Range of animal spawn on left
        Vector3 spawnleftPosition = new Vector3(-spawnSideX, 0, Random.Range(0, spawnSideZ));

        Instantiate(animalPrefabs[animalIndex], spawnrightPosition, Quaternion.Euler(rotationLeft));

        Instantiate(animalPrefabs[animalIndex], spawnleftPosition, Quaternion.Euler(rotationRight));
    }
}
