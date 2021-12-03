using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float minTime = 1f;
    public float maxTime = 3f;

    [SerializeField]
    private EnemyScript enemyToSpawn;


    [SerializeField]
    private float spawnRegionWidth;


    [SerializeField]
    private Bunkers bunkers;

    public IEnumerator startSpawning()
    {
        SpawnEnemy();
        yield return new WaitForSeconds(Random.Range(minTime, maxTime));
        StartCoroutine(startSpawning());
    }

    private void SpawnEnemy()
    {
        EnemyScript enemyInstance = Instantiate(enemyToSpawn, getRandomPos(), Quaternion.identity);
        enemyInstance.assigneTarget(bunkers.randomBase(), Random.Range(2f, 5f));
    }

    private Vector3 getRandomPos()
    {
        float randomx = Random.Range(-spawnRegionWidth, spawnRegionWidth);
        return new Vector3(randomx, transform.position.y, transform.position.z);
    }

    public void Stop()
    {
        StopAllCoroutines();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startSpawning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
