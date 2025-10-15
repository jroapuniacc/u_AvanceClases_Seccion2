using UnityEngine;

[System.Serializable]
public class Item
{
    // Nombre del ítem
    public string nameObject;
    // Descripción del ítem
    public string descriptionObject;

    public Item(string name, string description)
    {
        nameObject = name;
        descriptionObject = description;
    }
    
    
}
