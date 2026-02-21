using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    // Travel UI
    // Load a given scene
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
