using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    // Lista que almacena los ítems del inventario
    public List<Item> itemList  = new List<Item>();

    public void AddItem(Item item)
    {
        itemList.Add(item);
        Debug.Log("Item Added: " + item.nameObject);
    }

    public bool HasItem(string itemName)
    {
        foreach (Item item in itemList)
        {
            // si el ítemName que te entrego es igual al que tienes comprueba que es verdadero
            if (item.nameObject == itemName)
            {
                return true;
            }
        }
        return false;
    }
    
}
