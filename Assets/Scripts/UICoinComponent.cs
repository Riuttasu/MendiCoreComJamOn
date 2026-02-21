using UnityEngine;

public class UICoinComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject[] coins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ganarMoneda.AddListener(UpdateUI);
            UpdateUI(GameManager.instance.GetCount("Coin"));
        }
    }
    private void UpdateUI(int numcoins)
    {
        if (coins.Length != 0)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i].SetActive(i < numcoins);
            }
        }
    }

}
