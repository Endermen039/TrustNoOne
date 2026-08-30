using UnityEngine;

public class Painting2 : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("A purple tulip grows on a warm Summer's day");

    }
}
