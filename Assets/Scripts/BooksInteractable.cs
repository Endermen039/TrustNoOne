using UnityEngine;

public class BooksInteractable : Interactable
{ 
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("A few books are stacked high, gardening 101, trapping 101, portals 101");

    }
}
