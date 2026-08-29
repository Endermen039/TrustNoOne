using UnityEngine;

public class VinesInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("Vines have overgrown in the room, there appears to be a safe behind it but you can't reach it");

    }
}
