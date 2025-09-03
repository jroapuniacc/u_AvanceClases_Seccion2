using System;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections;

public class Interactions : MonoBehaviour
{
    [Header("KEYS")]
    [Tooltip("Arcorisia... este es un bolleano")]
    [SerializeField] private bool key1;
    [Tooltip("Arcorisia... este es un otro bolleano")]
    [SerializeField] private bool key2;
    
    [Header("DOOR")]
    [Tooltip("Arcorisia... arrastra el pivotdoor.. el que tiene el Animator")]
    [SerializeField] private GameObject door;
    private Animator animatorDoor;
    private bool isDoorShut = false;
    public GameObject doorFather;
    public Collider doorCollider;
    
    [Header("Health")]
    [SerializeField] private float health = 100f;
    [SerializeField] private int healthDecrease = 5;
    [SerializeField] private int healthIncrease = 10;
    
    [Header("UI")]
    [SerializeField] private GameObject uIDangerZone;

    private IEnumerator corrutinaDangerZone;
    
    
    private void Start()
    {
        animatorDoor = door.GetComponent<Animator>();
        doorCollider = door.GetComponent<Collider>();
        corrutinaDangerZone = DangerZone();
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
                if (key1 || key2)
                {
                    Debug.Log("Abrí la puerta");
                    animatorDoor.SetBool("Anim_Door", true);
                }
                break;
            case "ZoneDanger":
                StartCoroutine(corrutinaDangerZone);
                break;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        switch (other.tag)
        {
            case "Door":
                animatorDoor.SetBool("Anim_Door", false);
                isDoorShut = true;
                doorCollider.isTrigger = false; 
                break;
            case "ZoneDanger":
                StopCoroutine(corrutinaDangerZone);
                uIDangerZone.SetActive(false);
                break;
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        switch (other.tag)
        {
            case "ZoneDanger":
                if (isDoorShut == true)
                {
                    health -= healthDecrease * Time.deltaTime;
                    Debug.Log("Mi vida es: " + health);
                }
                break;
            case "ZoneHealth":
                if (isDoorShut == true)
                {
                    health += healthIncrease;
                    Debug.Log("Mi vida es: "  + health); // Concatenar
                }
                break;
        }
    }*/

    IEnumerator DangerZone()
    {
        while (health >= 0)
        {
            health -= healthDecrease;
            uIDangerZone.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            uIDangerZone.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }
    }
}


