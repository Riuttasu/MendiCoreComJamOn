using UnityEngine;

public class CheckStrings : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (LevelManager.instance != null && GameManager.instance != null)
        {
            if (GameManager.instance.GetCount("String") == 6)
            {
                LevelManager.instance.EndGame();
            }
        }
    }
}
