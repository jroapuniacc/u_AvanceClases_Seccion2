using System;
using UnityEngine;

public class InteractionsNPC : MonoBehaviour
{
    public bool key1;
    public bool key2;
    
    // Referencia al inventario del personaje
    private Inventory playerInventory;

    private void Start()
    {
        playerInventory = GetComponent<Inventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "NPC1":
                key1 = true;
                // Crear un nuevo (dato) ítem de Key1
                Item key1Item = new Item("Key1", "Una llave de dos");
                // Agregar el ítem al inventario
                playerInventory.AddItem(key1Item);
                //Destruye el objeto
                //Destroy(other.gameObject);
                other.isTrigger = false;
                break;
            case "NPC2":
                // Crear un nuevo (dato) ítem de Key1
                Item key2Item = new Item("Key2", "Una llave de dos");
                // Agregar el ítem al inventario
                playerInventory.AddItem(key2Item);
                //Destruye el objeto
                //Destroy(other.gameObject);
                other.isTrigger = false;
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
