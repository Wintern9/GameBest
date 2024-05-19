using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = transform.forward * moveSpeed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + movement);
    }
}
