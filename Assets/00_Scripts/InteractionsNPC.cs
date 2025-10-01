using System;
using UnityEngine;

public class InteractionsNPC : MonoBehaviour
{
    private bool key1;
    private bool key2;


    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "NPC1":
                key1 = true;
                break;
            case "NPC2":
                key2 = true;
                break;
            
        }
    }

    // método booleano con x nombre
    public bool AllKeysCollected()
    {
        // return que llave 1 y llave 2 son verdaderos
        return key1 && key2;
    }
}
