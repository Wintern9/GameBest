using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float moveHorizontalSpeed = 3f;
    [SerializeField] private GameObject PlayerModel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(PlayerModel == null)
        {
            PlayerModel = GameObject.FindGameObjectWithTag("PlayerModel").gameObject;
        }
    }

    void Update()
    {
        Vector3 movement = transform.forward * moveSpeed * Time.deltaTime;

        Debug.Log($"{movement.x} ,{movement.y} ,{movement.z}");

        movement.x = Mathf.Lerp(0,GetVectorMovement().x * moveHorizontalSpeed * Time.deltaTime, 1);
        if(movement.x != 0)
        {

        }

        rb.MovePosition(rb.position + movement);
    }

    private void ModelRotation()
    {

    }

    private VectorMovement GetVectorMovement()
    {
        return ButtonControllerPlayer.playerVector;
    }
}
