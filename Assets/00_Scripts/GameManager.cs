using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Debug.Log("Soy el único Dios! muerte piumpium");
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
        if (health <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("RestartMenu");
    }

    public void RestartHealth()
    {
        health = 100;
    }
    
    
    
   
    
    
}
