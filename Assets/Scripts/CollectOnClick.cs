using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectOnClick : MonoBehaviour
{
    [SerializeField]
    private string obj;
    private void Awake()
    {
        if (GameManager.instance != null)
        {
            string objID = SceneManager.GetActiveScene().name + "_" + obj;
            if (GameManager.instance.collectedItems.Contains(objID))
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnMouseDown()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.GainObject(obj);
        }

        gameObject.SetActive(false);
    }
}
