using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class spawn_attack : MonoBehaviour

{
   GameObject gameobject;
    public GameObject attack;

    public float _minimumSpawnTime;

    public float _maximumSpawnTime;

    private float _timeUntilSpawn;
    // Start is called before the first frame update
    void Start()
    {
        SetTime();
    }


    // Update is called once per frame
    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Destroy(gameobject);
            gameobject = Instantiate(attack, transform.position + Vector3.up, Quaternion.identity);
            SetTime();
        }
    }

    private void SetTime()
    {
        _timeUntilSpawn = UnityEngine.Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}

