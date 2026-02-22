using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Instance
    public static SoundManager instance;
    [Header("Audio Source")]
    [SerializeField]
    private AudioSource musicSrc;
    [SerializeField]
    private AudioSource sfxSrc;
    [Header("Clips")]
    [SerializeField]
    private AudioClip gamemusic;
    [SerializeField]
    private AudioClip endmusic;
    [SerializeField]
    private AudioClip sfxclip;
    [SerializeField]
    private AudioClip pickup;
    private void Awake()
    {
        if (instance != null) { Destroy(this); }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);

            if (gamemusic != null)
            {
                // Only start if it's not already playing (prevents double-play)
                if (!musicSrc.isPlaying)
                {
                    musicSrc.clip = gamemusic;
                    musicSrc.loop = true;
                    musicSrc.Play();
                }
            }

        }
    }
    public void PlaySound(string sfx)
    {
        switch (sfx)
        {
            case "Pickup": sfxSrc.PlayOneShot(pickup); break;
            default: Debug.LogWarning("No sfx with requested name"); sfxSrc.PlayOneShot(sfxclip); break;
        }
    }
    public void ChangeMusic(string music)
    {
        musicSrc.Stop();
        AudioClip newmusic = null;
        switch (music)
        {
            case "Game": newmusic = gamemusic;  break;
            case "EndGame": newmusic = endmusic; break;
            default: Debug.LogWarning("No music associated with that name"); break;
        }
        musicSrc.clip = newmusic;
        musicSrc.Play();
    }
}
