using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public float minTime = 1f;
    public float maxTime = 3f;
    public float movement_speed;
    private Vector3 start_pos;
    public Vector3 target_pos;
    private Vector3 current_target;

    [Header("Components")]
    [SerializeField]
    private Rigidbody2D rig;

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
        enemyInstance.transform.position = transform.position;
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
        start_pos = transform.position;
        current_target = target_pos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, current_target, movement_speed * Time.deltaTime);

        //Switch current target if it's reached the target
        if (transform.position == current_target)
        {
            if (current_target == start_pos)
            {
                current_target = target_pos; 
                transform.Rotate(Vector3.forward * 180f);
            }
            else
            {
                current_target = start_pos;
                transform.Rotate(Vector3.forward * 180f);
            }
        }

    }
}
