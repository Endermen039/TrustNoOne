using UnityEngine;

public class FernInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("Just a fern, there appears to be a couple bites out of it");

    }
}
