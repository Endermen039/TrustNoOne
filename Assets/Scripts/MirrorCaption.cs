using UnityEngine;

public class MirrorCaption : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("'No one but yourself'");

    }
}
