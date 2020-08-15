using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] badGuys;
    public GameObject powerup;
    private float zBadGuySpawn = 12.0f;
    private float XSpawnRange = 16.0f;
    private float zpowerupRange = 16.0f;
    private float ySpawn = 0.75f;

    private float powerupSpawnTime = 5.0f;
    private float badGuySpawnTime = 1.0f;
    private float startDelay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnRandomBadGuy();
        //SpawnPowerup();
        InvokeRepeating("SpawnRandomBadGuy", startDelay, badGuySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBadGuy()
    {
        float randomX = Random.Range(-XSpawnRange, XSpawnRange);
        int randomIndex = Random.Range(0, badGuys.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zBadGuySpawn);
        Instantiate(badGuys[randomIndex], spawnPos, badGuys[randomIndex].gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-XSpawnRange, XSpawnRange);
        float randomZ = Random.Range(-zpowerupRange, zpowerupRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }
}
