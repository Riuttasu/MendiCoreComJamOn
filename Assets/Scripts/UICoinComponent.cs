using UnityEngine;

public class UICoinComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject[] coins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.instance.ganarMoneda.AddListener(UpdateUI);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // 
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
