using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnCircle : MonoBehaviour
{
    public GameObject ItemPrefab;
    public float Radius = 20;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) SpawnObjectTwenty();
        if (Input.GetKeyDown(KeyCode.X)) SpawnObjectThirty();
        if (Input.GetKeyDown(KeyCode.C)) SpawnObjectHundred();

    }

    public void SpawnObjectTwenty() {
        DestroySpawn();
        for (int i = 0; i < 20; i++)
        {
            Vector2 randomPoint = new Vector2(Random.Range(-9.0f, 9.0f), Random.Range(-5.0f, 6.0f));
            Vector3 randomPos = randomPoint * Radius;
            Instantiate(ItemPrefab, randomPos, Quaternion.identity);
        }
    }

    public void SpawnObjectThirty()
    {
        DestroySpawn();

        for (int i = 0; i < 30; i++)
        {
            Vector2 randomPoint = new Vector2(Random.Range(-9.0f, 9.0f), Random.Range(-5.0f, 6.0f));
            Vector3 randomPos = randomPoint * Radius;
            Instantiate(ItemPrefab, randomPos, Quaternion.identity);
        }
    }

    public void SpawnObjectHundred()
    {
        DestroySpawn();

        for (int i = 0; i < 100; i++)
        {
            Vector2 randomPoint = new Vector2(Random.Range(-9.0f, 9.0f), Random.Range(-5.0f, 6.0f));
            Vector3 randomPos = randomPoint * Radius;
            Instantiate(ItemPrefab, randomPos, Quaternion.identity);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(this.transform.position, Radius);
    }

    void DestroySpawn() {
        GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawn");
        foreach (var spawn in spawners)
        {
            GameObject.Destroy(spawn);
        }
    }
}
