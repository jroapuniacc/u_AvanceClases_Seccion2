using UnityEngine;

[System.Serializable]
public class Item
{
    // Nombre del ítem
    public string nameObject;
    // Descripción del ítem
    public string descriptionObject;
    // Icono para representar el item
    public Sprite icon;
    
    public Item(string name, string description, Sprite iconSprite)
    {
        nameObject = name;
        descriptionObject = description;
        icon = iconSprite;
    }
    
}
