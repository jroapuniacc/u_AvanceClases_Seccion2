using System;
using Unity.VisualScripting;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private bool key1 = false;
    [SerializeField] private bool key2 = false;
    [SerializeField] private GameObject door;
    private Animator animatorDoor;

    private void Start()
    {
        animatorDoor = door.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "NPC1":
                Debug.Log("Obtuve la llave 1.. al fin");
                key1 = true;
                break;
            case "NPC2":
                Debug.Log("Obtuve la llave 2.. al fin");
                key2 = true;
                break;
            case "Door":
                Debug.Log("Abrí la puerta");
                animatorDoor.SetBool("Anim_Door", true);
                break;
            default:
                Debug.Log("Anda, buscas las llaves");
                break;
        }
        
       
       
    }
    
}


