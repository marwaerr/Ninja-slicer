using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitespawner : MonoBehaviour
{
    public GameObject[] fruit;
    public Transform[] spawpoints;
    public float minDelay = .1f;
    public float maxDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());

    }
    IEnumerator SpawnFruits()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);
            int spawnIndex = Random.Range(0, spawpoints.Length);
            int Index = Random.Range(0, fruit.Length);
            Transform spawnpoint = spawpoints[spawnIndex];
            GameObject span= Instantiate(fruit[Index], spawnpoint.position, spawnpoint.rotation);
            Destroy(span, 3f);
        }

    }

}
