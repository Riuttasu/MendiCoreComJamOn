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
        if (SoundManager.instance!= null) { SoundManager.instance.ChangeMusic("Game"); }
    }
    // Return to game menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Plays the end scene
    public void EndGame()
    {
        SceneManager.LoadScene("EndGame");
        if (SoundManager.instance != null)
        {
            SoundManager.instance.ChangeMusic("EndGame");
        }
    }
}
