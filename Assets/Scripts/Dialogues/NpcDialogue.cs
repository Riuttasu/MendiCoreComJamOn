using UnityEngine;

public class NpcDialogue : MonoBehaviour
{
    public NpcDialogue[] conversation;
    
    private DialogueManager dialogueManager;
    private bool dialogueStarted = false;

    void Start()
    {
        dialogueManager = GameManager.instance.GetComponent<DialogueManager>();
    }

    void Update()
    {
        
    }
}
