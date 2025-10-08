using System;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private InteractionsNPC interactionsNPC;
    private void OnTriggerEnter(Collider other)
    {
        if (interactionsNPC.key1 && interactionsNPC.key2)
        {
            Debug.Log("Abro la puerta");
        }
        
        if (interactionsNPC.AllKeysCollected())
        {
            Debug.Log("Abro la puerta");
        }
    }
}
