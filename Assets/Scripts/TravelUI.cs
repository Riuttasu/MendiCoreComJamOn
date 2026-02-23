
using UnityEngine;
using UnityEngine.SceneManagement;

public class TravelUI : MonoBehaviour
{
    [SerializeField] // Lista de botones de travel
    private GameObject[] buttons;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        // Esconde todos los botones
        foreach(GameObject bt in buttons)
        {
            bt.gameObject.SetActive(false); 
        }
        // Mira la escena y activa los correctos
        string currentscene = SceneManager.GetActiveScene().name;
        switch (currentscene)
        {
            case "Fuera": ActivateButtons(1); break;
            case "Cafeta": ActivateButtons(0, 2, 3); break;
            case "Hall": ActivateButtons(1); break;
            case "Roca":
                if (GameManager.instance.GetCount("String") == 5) { ActivateButtons(1, 4, 5, 6); }
                else { ActivateButtons(1, 4, 5); }; 
                break;
            case "LAG": ActivateButtons(3); break;
            case "ASCII": ActivateButtons(3); break;
            case "Toni": ActivateButtons(3); break;
            case "Basura": ActivateButtons(3); break;
            case "TestTravel": ActivateButtons(0, 1, 2, 5, 6); break;
            default: Debug.LogError("Escena no encontrada en base de travel");  break;
        }
    }
    // Activa los botones deseados
    // 0 - fuera, 1 - cafeta, 2 - hall , 3 - roca, 4 - lag, 5 - ascii, 6 - toni
    private void ActivateButtons(params int[] bt)
    {
        foreach(int i in bt)
        {
            if (i < buttons.Length) { buttons[i].SetActive(true); }
        }
    }
}
