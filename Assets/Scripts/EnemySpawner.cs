using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float timeBetweenSpawns;
    public float spawnTimer;
    public GameObject basicEnemy;

    void FixedUpdate()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= timeBetweenSpawns)
        {
            GameObject temp = Instantiate(basicEnemy);
            temp.transform.position = new Vector3(transform.position.x + Random.Range(-3, 3) + (Random.Range(1,10) * .1f), transform.position.y, transform.position.z);
            spawnTimer = 0;
        }
    }
}
