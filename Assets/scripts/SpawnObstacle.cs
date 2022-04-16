using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawns;
    public float spawnTime;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {   spawn();
            spawnTime = Time.time + timeBetweenSpawns;
            
        }
    }

    void spawn(){
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(x, y, 0);
        Instantiate(obstacle, transform.position +  spawnPosition, transform.rotation);
    }
}
