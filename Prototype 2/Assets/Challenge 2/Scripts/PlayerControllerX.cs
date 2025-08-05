using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float nextSpawnTime = 0f;
    private float spawnCooldown = 0.75f;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // DogSpawn();
         if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawnTime)
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        nextSpawnTime = Time.time + spawnCooldown;
    }
    }

    // void DogSpawn()
    // {
    //     if (Time.time > nextSpawnTime)
    //     {
    //         nextSpawnTime = Time.time + spawnCooldown;

    //         // On spacebar press, send dog
    //         if (Input.GetKeyDown(KeyCode.Space))
    //         {
    //             Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    //         }
    //     }
    // }
}
