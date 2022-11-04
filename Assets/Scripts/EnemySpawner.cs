using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public TimerScript timerScript;

    void Start()
    {
        StartCoroutine(enemyTimer());
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator enemyTimer()
    {
        yield return new WaitForSeconds(4);
        int randEnemy = Random.Range(0, enemyPrefabs.Length);
        int randSpawnPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);
        StartCoroutine(enemyTimer());
    }
}
