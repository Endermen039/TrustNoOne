using UnityEngine;

public class ClockInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    { 
        dialogueManager.ShowDialogue("It's a clock, although it seems to be broken");

    }

}
