using UnityEngine;

public class BookshelfInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("It's a bookshelf with many colourful books from novels to textbooks");

    }
}
