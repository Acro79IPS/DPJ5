using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetected : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}