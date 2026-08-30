using UnityEngine;

public class OriginalPainting : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("A painting of an erupting volcano");

    }
}
