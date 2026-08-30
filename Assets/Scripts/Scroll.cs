using UnityEngine;

public class Scroll : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("A scroll with the text: 'There's something weird...'");

    }
}
