//using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemies : MonoBehaviour
{
    
    public GameObject _enemyPrefab;

    public float _minimumSpawnTime;

    public float _maximumSpawnTime;

    private float _timeUntilSpawn;
    // Start is called before the first frame update
    void Start()
    {
        _minimumSpawnTime -= 550;
        if (_minimumSpawnTime < 0) { 
        _minimumSpawnTime = 0;
        } 
        _maximumSpawnTime += 300;
        SetTime();
    }
    

    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0) {

            Instantiate(_enemyPrefab, transform.position + Vector3.up, Quaternion.identity);
            SetTime();
        }
    }

    private void SetTime()
    {
        _timeUntilSpawn = UnityEngine.Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
