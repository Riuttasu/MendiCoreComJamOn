using UnityEngine;
using UnityEngine.SceneManagement;

public class TravelButton : MonoBehaviour
{
    public void TravelToScene()
    {
        string SceneLoaded = gameObject.name;
        var manager = Object.FindFirstObjectByType<LevelManager>();
        if (manager != null)
        {
            manager.LoadScene(SceneLoaded);
        }
    }
}
