using UnityEngine;

public class Bookshelf1 : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("A tall bookshelf full of colourful books");

    }
}
