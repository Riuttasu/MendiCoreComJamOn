using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckMus : MonoBehaviour
{
    [SerializeField]
    private GameObject activateobj;
    private void OnMouseDown()
    {
        if (GameManager.instance != null)
        {
            if (GameManager.instance.HasMus())
            {

                string objID = SceneManager.GetActiveScene().name + "_" + activateobj;
                if (GameManager.instance != null) if (!GameManager.instance.collectedItems.Contains(objID)) activateobj.SetActive(true);
            }
        }
    }
}
