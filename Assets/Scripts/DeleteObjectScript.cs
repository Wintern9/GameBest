using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObjectScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        try
        {
            Destroy(other.transform.parent.gameObject);
        } catch
        {
            Destroy(other.gameObject);
        }
    }
}
