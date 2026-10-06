using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;

    private void Start()
    {
        SpawnEnemyWave(3);
    }

    private void Update()
    {
        // we also can use Include, it doesn't matter since we don't have inactive enemies in our scene,but Exclude is faster
        enemyCount = FindObjectsByType<Enemy>(FindObjectsInactive.Exclude).Length;

        if (enemyCount == 0)
        {
            SpawnEnemyWave(1);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}
