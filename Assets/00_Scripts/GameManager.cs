using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Static: nunca muere, existe siempre dentro del juego, está en todas las escenas
    public static GameManager instance;

    public int health = 100;
    
    private void Awake() //Se inicia antes del all
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void AddHealth(int sumaVida) // Puerta abierta a manejar la vida
    {
        health += sumaVida;
    }

    public void MinusHealth(int restaVida)
    {
        health -= restaVida;
    }
    
    
   
    
    
}
