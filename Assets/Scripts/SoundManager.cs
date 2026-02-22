using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Instance
    public static SoundManager instance;
    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private AudioSource sfx;
    private void Awake()
    {
        if (instance != null) { Destroy(this); }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

}
