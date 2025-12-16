using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fly;
    public Transform[] spawnPoints;
    public float timeBetweenSpawns;
    float nextSpawnTime;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            Instantiate(
                fly,
                spawnPoints[Random.Range(0, spawnPoints.Length)].position,
                Quaternion.identity
            );
            //Instantiate(what, where, rotation)
            //Quaternion.identity = spawn it straight, not tilted

            nextSpawnTime = Time.time + timeBetweenSpawns;
        }
    }
}
