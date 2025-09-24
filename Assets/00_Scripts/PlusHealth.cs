using System;
using UnityEngine;

public class PlusHealth : MonoBehaviour
{
    [SerializeField] private int healthIncrease = 10;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddHealth(healthIncrease);
        }
    }
}
