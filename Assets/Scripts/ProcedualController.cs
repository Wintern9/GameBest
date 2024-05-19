using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcedualController : MonoBehaviour
{
    [SerializeField] private GameObject[] procedualPrefabs;

    public GameObject[] GetProcedualPrefabs() { return procedualPrefabs; }
}
