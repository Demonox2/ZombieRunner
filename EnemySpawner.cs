using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject Enemy;

    public float DownTime = 10.0f;

    private float SpawnTimer = 5.0f;

    private PlayerController playercontroller;

    private void Awake()
    {
        playercontroller = GetComponent<PlayerController>();//to reference PlayerController health values
    }

    void Update()
    {
        if (Time.time >= SpawnTimer)

        {
            SpawnCollectables();
            SpawnTimer = Time.time + DownTime;
        }

    }

    public void SpawnCollectables()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(Enemy, spawnPoints[i].position, spawnPoints[i].rotation);
            }
        }
    }
}
