using System.Collections.Generic;
using UnityEngine;

public class DialogueUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject dialogueWindow;

    [SerializeField] private GameObject optionButtonPrefab;
    [SerializeField] private Transform optionsParent;

    private readonly List<GameObject> optionPool = new List<GameObject>();

    void OnEnable()
    {
        if (DialogueManager.Instance != null)
            DialogueManager.Instance.OnDialogueRequested += HandleDialogueRequest;
    }

    void OnDisable()
    {
        if (DialogueManager.Instance != null)
            DialogueManager.Instance.OnDialogueRequested -= HandleDialogueRequest;
    }
    private void HandleDialogueRequest(AdvancedDialogues data)
    {
        if (data == null) return;

        // Example: show window and log first lines. Replace with real UI population.
        if (dialogueWindow != null)
            dialogueWindow.SetActive(true);

        if (data.dialogues != null && data.dialogues.Length > 0)
        {
            Debug.Log($"DialogueUIHandler: starting dialogue. First line: {data.dialogues[0]}");
        }
        else
        {
            Debug.Log("DialogueUIHandler: dialogue has no lines.");
        }
    }
}
