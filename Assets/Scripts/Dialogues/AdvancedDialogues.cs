using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "AdvancedDialogues", menuName = "Scriptable Objects/AdvancedDialogues")]
public class AdvancedDialogues : ScriptableObject
{
    public Npcs[] npcs;

    [Header ("Dialogue")]
    [TextArea]
    public string[] dialogues;

    [Tooltip ("The words that will appear in options")]
    public string[] optionText;

    public AdvancedDialogues option0;
    public AdvancedDialogues option1;
    public AdvancedDialogues option2;
    public AdvancedDialogues option3;
}
