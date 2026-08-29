using UnityEngine;

public class PictureInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        Debug.Log("You see a picture frame, a large cactus stands tall in the middle of a desert");
        dialogueManager.ShowDialogue("You see a picture of a lone cactus standing amidst rolling dunes of sand");

    }

}
