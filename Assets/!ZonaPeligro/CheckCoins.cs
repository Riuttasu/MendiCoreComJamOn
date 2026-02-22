using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckCoins : MonoBehaviour
{
    [SerializeField]
    private GameObject activatedobj;
    private bool hascoin = false;
    private void Awake()
    {
        string objID = SceneManager.GetActiveScene().name + "_" + activatedobj;
        if (!hascoin) { activatedobj.SetActive(false); }
        else { if (GameManager.instance != null) if (!GameManager.instance.collectedItems.Contains(objID)) activatedobj.SetActive(true); }
    }
    private void CheckCoin()
    {

        string objID = SceneManager.GetActiveScene().name + "_" + activatedobj;
        if (GameManager.instance != null)
        {
            if (GameManager.instance.GetCount("Coin") == 5)
            {
                GameManager.instance.RemoveCoin();
                hascoin = true;
                if (GameManager.instance != null) if (!GameManager.instance.collectedItems.Contains(objID))  activatedobj.SetActive(true);
            }
        }
    }
}
