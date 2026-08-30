using UnityEngine;

public class MirrorScrollInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;

    public bool scrollRead = false;

    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("Another scroll that reads: 'About that cactus'");
        scrollRead = true;

    }
}
