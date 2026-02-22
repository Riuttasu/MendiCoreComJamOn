using UnityEngine;

public class CheckCoins : MonoBehaviour
{
    [SerializeField]
    private GameObject activatedobj;
    private bool hascoin = false;
    private void Awake()
    {
        if (!hascoin) { activatedobj.SetActive(false); }
        else { activatedobj.SetActive(true); }
    }
    private void CheckCoin()
    {
        if (GameManager.instance != null)
        {
            if (GameManager.instance.GetCount("Coin") == 5)
            {
                GameManager.instance.RemoveCoin();
                hascoin = true;
                activatedobj.SetActive(true);
            }
        }
    }
}
