using UnityEngine;

public class GiveMus : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (GameManager.instance != null) {  GameManager.instance.GiveMus(); }
    }
}
