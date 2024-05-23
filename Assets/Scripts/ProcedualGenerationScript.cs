using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcedualGenerationScript : MonoBehaviour
{
    ProcedualController controller;

    [SerializeField] private GameObject spawnPosition;
    private float spawnInterval = 2.0f;

    void Start()
    {
        controller = FindFirstObjectByType<ProcedualController>();
        controller.Platforms.Add(gameObject);
    }

    public void SpawnObject()
    {
        if(Instantiate(controller.GetRandomProcedualPrefabs(), spawnPosition.transform.position, Quaternion.identity))
        { 
            //Destroy(gameObject);
        }
    }
}
