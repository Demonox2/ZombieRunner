using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour {

    public Transform[] spawnPoints;

    public GameObject Collectable;

    public float DownTime = 10.0f;

    private float SpawnTimer = 5.0f;

    private PlayerController playercontroller;

    


    private void Awake()
    {
        playercontroller = GetComponent<PlayerController>(); //to reference PlayerController health values
        
    }

    /*private float NewHealth = (playercontroller.Maxhealth - playercontroller.health)/10;*/

    void Update()
    {
        if (Time.time >= SpawnTimer)
        
        {
          SpawnCollectables();
          SpawnTimer = Time.time + DownTime /*NewHealth*/;
        }

    }

    public void SpawnCollectables()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(Collectable, spawnPoints[i].position, spawnPoints[i].rotation);
            }
        }
    }
}
