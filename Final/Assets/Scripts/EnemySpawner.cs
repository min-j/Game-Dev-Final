using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float spawnTimer = 5f;

    private void Start()
    {
        //StartSpawning();
    }

    private void OnEnable()
    {
        EventManager.onStartGame += StartSpawning;
    }

    private void OnDisable()
    {
        StopSpawning();
        EventManager.onStartGame -= StartSpawning;
    }

    void SpawnEnemy() {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnEnemy", spawnTimer, spawnTimer);
    }

    void StopSpawning() {
        CancelInvoke();
    }
}
