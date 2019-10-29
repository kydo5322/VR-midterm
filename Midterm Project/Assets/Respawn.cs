using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    //public Transform ghostDrop;
    public GameObject enemy;
    public int numToSpawn;
    public Vector3 position;

    void Awake()
    {
        Vector3 position = new Vector3(Random.Range(-5.0F, 5.0F), 1, Random.Range(-5.0F, 5.0F));
    }

    void Start()
    {
        int spawned = 0;

        while (spawned < numToSpawn)
        {
            position = new Vector3(Random.Range(-5.0F, 5.0F), 1, Random.Range(-5.0F, 5.0F));
            //Instantiate(ghostDrop, position, Quaternion.identity);
            Instantiate(enemy, position, Quaternion.identity);
            spawned++;
        }
    }
}
