using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcedualController : MonoBehaviour
{
    [SerializeField] private GameObject[] procedualPrefabs;
    private float spawnInterval = 2.0f;

    public GameObject[] GetProcedualPrefabs() { return procedualPrefabs; }
    public GameObject GetRandomProcedualPrefabs() {
        return procedualPrefabs[UnityEngine.Random.Range(0, procedualPrefabs.Length)]; 
    }
    public List<GameObject> Platforms;

    void Start()
    {
        InvokeRepeating("SpawnObject", 0, spawnInterval);
    }

    int i = 0;
    public void SpawnObject()
    {
        Platforms[i].GetComponent<ProcedualGenerationScript>().SpawnObject();
        i++;
    }
}
