using UnityEngine;

public class OpenDialogue : MonoBehaviour
{
    [SerializeField]
    private GameObject dialogueWindow;
    [SerializeField]
    private AdvancedDialogues dialogueData;
    private bool isDialogueOpen = false;
    public string[] dialogueLines;
    [SerializeField]
    private GameObject spriteSpace;
    [SerializeField]
    private Sprite[] npcSprites;

    void Start()
    {
        dialogueWindow.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleClick();
        }
    }
    private void HandleClick()
    {
        if (dialogueWindow == null) return;

        var cam = Camera.main;
        if (cam == null)
        {
            return;
        }

        Vector3 worldPoint3 = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 worldPoint = new Vector2(worldPoint3.x, worldPoint3.y);

        // Use 2D overlap at the click point
        Collider2D hit = Physics2D.OverlapPoint(worldPoint);
        if (hit == null) return;

        // Only open if the clicked collider belongs to this GameObject (or its child/parent)
        if (!isDialogueOpen)
        {
            if (hit.transform == transform || hit.transform.IsChildOf(transform) || transform.IsChildOf(hit.transform))
            {
                dialogueWindow.SetActive(true);
                isDialogueOpen = true;
            }
        }
        else
        {
            dialogueWindow.SetActive(false);
            isDialogueOpen = false;
        }
    }
}

