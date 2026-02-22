using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToActivateThings : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objs;
    private void OnMouseDown()
    {
        foreach(GameObject obj in objs)
        {
            string objID = SceneManager.GetActiveScene().name + "_" + obj;
            if (GameManager.instance != null) if (!GameManager.instance.collectedItems.Contains(objID)) obj.SetActive(true);
        }
    }
}
