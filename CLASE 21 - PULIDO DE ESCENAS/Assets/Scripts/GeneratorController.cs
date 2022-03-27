using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    enum Difficulties { Easy = 1, Normal, Hard };
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] float spawnInterval = 2f;
    [SerializeField] float spawnDelay = 2f;

    [SerializeField] private Difficulties difficulty;
    void Start()
    {
        switch (difficulty)
        {
            case Difficulties.Easy:
                InvokeRepeating("SpawnEnemy", (spawnDelay + 3f), (spawnInterval + 3f));
                break;
            case Difficulties.Normal:
                InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
                break;
            case Difficulties.Hard:
                InvokeRepeating("SpawnEnemy", (spawnDelay - 1f), (spawnInterval - 1f));
                break;
            default:
                Debug.Log("<color=#FF0000>ERROR AL ELEGIR NIVEL</color>");
                break;
        }

    }
    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
        //Instantiate(enemyPrefabs[1], transform);
        Instantiate(enemyPrefabs[enemyIndex], transform.position, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
