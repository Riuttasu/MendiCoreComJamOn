using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    // Instance
    public static GameManager instance;
    // Collectables
    // Strings
    [SerializeField] 
    private GameObject[] strings;
    // Coins    
    [SerializeField]
    private GameObject[] coins;
    // Collectable data
    private int stringnum = 0; private int coinnum = 0;

    public UnityEvent<int> ganarCuerda;
    public UnityEvent<int> ganarMoneda;

    // Conditions
    private bool Mus = false;
    private void Awake()
    {
        if (instance != null) { Debug.Log("Another instance present"); Destroy(this); }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        UpdateGUI();
    }

    private void UpdateGUI()
    {
        // Collectables
        // Strings
        ganarCuerda.Invoke(stringnum);
        // Coins
        ganarMoneda.Invoke(coinnum);
    }
}