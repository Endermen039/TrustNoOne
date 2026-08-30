using UnityEngine;

public class Painting4 : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("'There's writing under the painting: from warm to cool the seasons change and all is revealed'");

    }
}
