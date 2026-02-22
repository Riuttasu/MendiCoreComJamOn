using UnityEngine;

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
                activateobj.SetActive(true);
            }
        }
    }
}
