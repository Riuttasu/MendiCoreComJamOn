using UnityEngine;

public class CollectOnClick : MonoBehaviour
{
    [SerializeField]
    private string obj;
    private void OnMouseDown()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.GainObject(obj);
        }
        gameObject.SetActive(false);
    }
}
