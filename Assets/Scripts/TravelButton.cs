using UnityEngine;
using UnityEngine.SceneManagement;

public class TravelButton : MonoBehaviour
{
    public void TravelToScene()
    {
        string SceneLoaded = gameObject.name;
        Debug.Log("Quiero viaja a la escena " +  SceneLoaded);
        var manager = Object.FindFirstObjectByType<LevelManager>();
        if (manager != null)
        {
            manager.LoadScene(SceneLoaded);
        }
    }
}
