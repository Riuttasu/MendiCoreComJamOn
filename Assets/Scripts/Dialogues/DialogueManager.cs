using System;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager Instance;
    public bool dialogueStarted = false;

    // Event fired when a dialogue is requested. Subscribers receive the ScriptableObject payload.
    public event Action<AdvancedDialogues> OnDialogueRequested;


    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
    /// <summary>
    /// Called by other scripts to start a dialogue using a ScriptableObject.
    /// </summary>
    public void RequestDialogue(AdvancedDialogues dialogueData)
    {
        if (dialogueData == null)
        {
            Debug.LogWarning("DialogueManager.RequestDialogue called with null dialogueData.");
            return;
        }

        dialogueStarted = true;
        OnDialogueRequested?.Invoke(dialogueData);
    }
    /// <summary>
    /// Optional: call when dialog finishes.
    /// </summary>
    public void EndDialogue()
    {
        dialogueStarted = false;
        // other cleanup
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum DialogueNpcs
{
    LuisPresiTroste,
    LuisPresiHappy,
    EduChill,
    EduHappy,
    EduEvil,
    NapochocoHappy,
    NapochocoEmm,
    MusAddict,
    Hermes,
    LaRoca,
    LAG,
    Loco,
    IsmaelChill,
    IsmaelPunyoFront,
    IsmaelPunyoSide,
    Branch
}
