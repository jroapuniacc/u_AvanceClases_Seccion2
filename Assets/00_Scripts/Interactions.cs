using System;
using Unity.VisualScripting;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private bool key1 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC1"))
        {
            key1 = true;
        }
    }
}


