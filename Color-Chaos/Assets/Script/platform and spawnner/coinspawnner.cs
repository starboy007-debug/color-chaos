using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawnner : MonoBehaviour
{
    public GameObject[] coin;
    public GameObject colorcoin;
    public float xPositionLimit;
    public float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        // SpawnSpike();
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnSpike()
    {
        float randomX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        if (Random.Range(0, 2) > 0)
        {
            Instantiate(coin[Random.Range(0,coin.Length)], spawnPosition, Quaternion.identity);
        }

        else
        {
            Instantiate(colorcoin, spawnPosition, Quaternion.identity);
        }
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnSpike");
    }

}
