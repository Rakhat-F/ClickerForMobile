using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;

    public int remaining;

    private int death = 1;

    public GameObject UI;
    public GameObject Menu;
    public GameObject button;

    [System.Obsolete]
    void Start()
    {
        float randSpawnTime = Random.RandomRange(1,5);
        float randSpawnDelay = Random.RandomRange(1,3);

        InvokeRepeating("SpawnEnemy", randSpawnTime, randSpawnDelay);
    }

    [System.Obsolete]
    void SpawnEnemy()
    {
        Debug.Log("FINDED");
        for (int i = 0; i < death; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(-65.0f, 65.0f), 7, Random.Range(-35.0f, 35.0f)), Quaternion.Euler(0, 0, 0));
            
            remaining++;   
        }

        if (remaining == 10)
        {
            Time.timeScale = 0;
            UI.SetActive(false);
            Menu.SetActive(true);
            button.SetActive(false);

            GameObject[] Cubes = (GameObject.FindGameObjectsWithTag("Cube") as GameObject[]);
            for (int i = 0; i < Cubes.Length; i++)
            {
                Destroy(Cubes[i]);
            }

            remaining = 0;
        }
    }
}



