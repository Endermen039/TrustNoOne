using UnityEngine;

public class MirrorInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("It's a mirror, you can make out your surroundings but it's quite cloudy");

    }
}
