using UnityEngine;

public class NpcDialogue : MonoBehaviour
{
    public NpcDialogue[] conversation;
    
    private DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager = GameManager.instance.GetComponent<DialogueManager>();
    }

    void Update()
    {
        
    }
}
