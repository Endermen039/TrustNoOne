using UnityEngine;

public class Painting3 :  Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("A candle melting away, 'just like your time to make a choice'");

    }
}
