using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcedualGenerationScript : MonoBehaviour
{
    ProcedualController controller;
    private GameObject[] ProcedualPrefabs;

    public GameObject spawnPosition;
    public float spawnInterval = 2.0f;

    void Start()
    {
        controller = FindFirstObjectByType<ProcedualController>();
        ProcedualPrefabs = controller.GetProcedualPrefabs();
        InvokeRepeating("SpawnObject", 0, spawnInterval);
    }

    void SpawnObject()
    {
        if(Instantiate(ProcedualPrefabs[0], spawnPosition.transform.position, Quaternion.identity))
        { 
            Destroy(gameObject);
        }
    }
}
