using UnityEngine;

public class Painting1 : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("It's a beautiful painting of the starry night sky, I hope I can see the sky soon");

    }
}
