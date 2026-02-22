using UnityEngine;

public class ClickToActivateThings : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objs;
    private void OnMouseDown()
    {
        foreach(GameObject obj in objs)
        {
            obj.SetActive(true);
        }
    }
}
