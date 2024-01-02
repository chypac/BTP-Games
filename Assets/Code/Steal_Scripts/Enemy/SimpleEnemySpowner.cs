using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemySpowner : soundctl
{
    public EnemyController enemyToSpawn;

    public Transform spawnPoint;

    public float timeBetweenSpawns;
    private float spawnCounter;

    public int amountToSpawn = 15;

    public Castle theCastle;
    public Path thePath;

    void Start()
    {
        spawnCounter = timeBetweenSpawns;
        Instantiate(enemyToSpawn, spawnPoint.position, spawnPoint.rotation).Setup(theCastle, thePath);
        amountToSpawn--;
        
    }

    void Update()
    {
        if (amountToSpawn > 0)
        {
            spawnCounter -= Time.deltaTime;
            if (spawnCounter <= 0)
            {
                spawnCounter = timeBetweenSpawns;
                PlaySound(sounds[0]);
                Instantiate(enemyToSpawn, spawnPoint.position, spawnPoint.rotation).Setup(theCastle, thePath);
                amountToSpawn --;
            }
        }


    }
}

