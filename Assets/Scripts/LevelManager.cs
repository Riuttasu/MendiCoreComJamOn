using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    // Instance
    public static LevelManager instance;
    private void Awake()
    {
        if (instance != null) { Destroy(this); }
        else
        {
            instance = this; 
            DontDestroyOnLoad(this.gameObject);
        }
    }
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    // Start Game - Cutscene
    public void StartGame()
    {
        SceneManager.LoadScene("Fuera");
    }
    // Return to game menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
