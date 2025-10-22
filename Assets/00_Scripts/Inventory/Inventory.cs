using System;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Inventory : MonoBehaviour
{
    // Lista que almacena los ítems del inventario
    public List<Item> itemList  = new List<Item>();
    
    // Referencia al panel del inventario
    public GameObject inventoryPanel;
    // Referencia al prefab del inventario
    public GameObject inventoryItemPrefab;
    private bool inventoryVisible;

    private void Update()
    {
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            // Si el inventario está abierto, y aprieto la I. Se Cierra
            // Else, si el inventario está cerrado, y aprieto la I, Se abre
            inventoryVisible = !inventoryVisible;
            inventoryPanel.SetActive(inventoryVisible);
        }
    }

    public void UpdateInventoryUI()
    {
        // limpiar los ítems actuales en el panel
        foreach (Transform child in inventoryPanel.transform)
        {
            Destroy(child.gameObject);
        }
        // Crear un elemento UI por cada objeto o item coleccionado
        foreach (Item item in itemList)
        {
            //Intanciar el prefab
            GameObject itemUI = Instantiate(inventoryItemPrefab, inventoryPanel.transform);
            
            // Accede al texto del gameobject llamadop InventoryText
            TextMeshProUGUI nameText = itemUI.transform.Find("InventoryText").GetComponent<TextMeshProUGUI>();
            nameText.text = item.nameObject;
            
            // Configurar la imagen del ítem
            Image iconImage = itemUI.GetComponent<Image>();
            iconImage.sprite = item.icon;
            
        }
        
    }
    
    public void AddItem(Item item)
    {
        itemList.Add(item);
        Debug.Log("Item Added: " + item.nameObject);
        // Actualiza la UI del inventario
        UpdateInventoryUI();
    }

    public void RemoveItem(string itemName)
    {
        
        Item itemRemove = null;
        // Buscar el item en la lista
        foreach (Item item in itemList)
        {
            // si el nombre del item es igual al itemname.
            if (item.nameObject == itemName)
            {
                itemRemove = item;
                break;
            }
        }
        
        // Si encontraste el item, elíminalo
        if (itemRemove != null)
        {
            itemList.Remove(itemRemove);
            Debug.Log("Item Removed: " + itemRemove.nameObject);
            UpdateInventoryUI();
        }
        
        // Pero si no lo encontraste avísanos 
        else
        {
            Debug.LogError("El item " + itemName + " no existe");
        }
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
