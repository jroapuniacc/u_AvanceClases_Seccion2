using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        // que suene el botón
        // Fade a negro
        GameManager.instance.RestartHealth();
        SceneManager.LoadScene("Game_Level1");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
