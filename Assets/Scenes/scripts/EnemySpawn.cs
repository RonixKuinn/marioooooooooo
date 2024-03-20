using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 0,5f;

    public float timer;
    public float waitTime = 3f;

    public Transform spawnPoint;

    private bool activateSpawn = false;

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if(activateSpawn = true)
        {
           SpawnEnemy(); 
        }
    }

    void SpawnEnemy()
    {
        timer += Time.deltaTime;

        if(timer >= waitTime)
        {
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            timer = 0;
        }
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            activateSpawn = true;
        }
    }

    void OnTriggerExit(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            activateSpawn = false;
        }
    }
}
