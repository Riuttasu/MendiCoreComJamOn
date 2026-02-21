using UnityEngine;

public class UIStringComponent : MonoBehaviour
{
    [SerializeField]
    private GameObject[] strings;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.ganarCuerda.AddListener(UpdateUI);
            UpdateUI(GameManager.instance.GetCount("String"));
        }
    }
    private void UpdateUI(int numstrings)
    {
        if (strings.Length != 0)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i].SetActive(i < numstrings);
            }
        }
    }

}
