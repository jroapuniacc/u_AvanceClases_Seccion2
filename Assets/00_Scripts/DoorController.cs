using System;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private InteractionsNPC interactionsNPC;
    private Inventory playerInventory;
    // Variable gameobject de la puerta
    // Variable del Animator

    private void Start()
    {
        // animator = objetoGetCompontet del Animator
        
        // Obtener el jugador que tiene el inventario
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            playerInventory = player.GetComponent<Inventory>();
        }
        else
        {
            Debug.LogError("No player found");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (interactionsNPC.AllKeysCollected())
        {
            // doorAnimator.Setbool nombre y true
            Debug.Log("Abro la puerta");
            playerInventory.RemoveItem("Key1");
            playerInventory.RemoveItem("Key2");
        }
    }
}
