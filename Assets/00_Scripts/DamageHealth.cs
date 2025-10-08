using System;
using UnityEngine;
using System.Collections;

public class DamageHealth : MonoBehaviour
{
    [SerializeField] private int healthDecrease = 10;
    private IEnumerator damageHealthCorrutine;
    
    
    private void Start()
    {
        damageHealthCorrutine = DamageHealthCorrutine();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(damageHealthCorrutine);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StopCoroutine(damageHealthCorrutine);
        }
    }

    IEnumerator DamageHealthCorrutine()
    {
        while (GameManager.instance.health >= 0)
        {
            GameManager.instance.MinusHealth(healthDecrease);
            yield return new WaitForSeconds(1f);
        }

        }

    public void Palanca()
    {
        
    }
}
