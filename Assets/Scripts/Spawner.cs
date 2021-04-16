using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<Transform> spawnPositionsList  = null;
    public GameObject enemyPrefab = null;
    public float SpawnPeriod;
    private float _nextSpawnTime;

    private void Start() {
        _nextSpawnTime = 5f;
    }

    private void Update() {
        if(Time.time >= _nextSpawnTime){
            //apparition ennemi
            SpawnEnemy();
            _nextSpawnTime =Time.time + SpawnPeriod;
        }
    }

    private void SpawnEnemy()
    
    {
        Vector3 randomPosition = spawnPositionsList[Random.Range(0,spawnPositionsList.Count)].position + new Vector3(0,1,0);


           GameObject enemy = Instantiate(enemyPrefab,randomPosition,Quaternion.identity);
    }

}
