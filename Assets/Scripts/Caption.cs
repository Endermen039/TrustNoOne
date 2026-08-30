using UnityEngine;

public class Caption : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("'Trust no one'");

    }
}
