using UnityEngine;

public class RandomAppearance : MonoBehaviour
{
    // There is a 1/3 chance Eri stays ;)
    private void Awake()
    {
        int russianroulette = Random.Range(0, 3);
        if (russianroulette != 0) { gameObject.SetActive(false); }
    }
}
