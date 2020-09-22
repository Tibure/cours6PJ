using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Xml.Serialization;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1;
    private float timeLeftBeforeSpawn = 0;
    private SpawnPoint[] spawnPoints;
    public GameObject ennemiCubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = FindObjectsOfType<SpawnPoint>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSpawn();
    }

    private void UpdateSpawn()
    {
        timeLeftBeforeSpawn -= Time.deltaTime;
        if (timeLeftBeforeSpawn <= 0)
        {
            SpawnEnnemiCube();
            timeLeftBeforeSpawn = spawnRate;
        }
    }

    private void SpawnEnnemiCube()
    {
        int countSpawnPoints = spawnPoints.Length;
        int randomSpawnPointsIndex = Random.Range(0, countSpawnPoints);
        SpawnPoint currentSpawnPoint = spawnPoints[randomSpawnPointsIndex];
        Instantiate(ennemiCubePrefab, currentSpawnPoint.transform.position, Quaternion.identity);
    }
}
