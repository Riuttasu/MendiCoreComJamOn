using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "ScriptableObjects/NewScriptableObject")]
public class NewScriptableObject : ScriptableObject
{
    [SerializeField] private TextMeshProUGUI NameText;
    [SerializeField] private GameObject DialogueSprite;
    [SerializeField] private TextMeshProUGUI DialogueText;
    [SerializeField] private GameObject Options;
    [SerializeField] private TextMeshProUGUI Option1Text;
    [SerializeField] private TextMeshProUGUI Option2Text;
    [SerializeField] private TextMeshProUGUI Option3Text;
}
