using UnityEngine;

public class EndMusic : MonoBehaviour
{
    private void Awake()
    {
        if (SoundManager.instance != null)
        {
            SoundManager.instance.ChangeMusic("EndGame");
        }
    }
}
