using UnityEngine;

public class PictureInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] MirrorScrollInteractable mirrorScrollScript;
    [SerializeField] GameObject colourCode;
    public override void OnInteract()
    {
        if (mirrorScrollScript.scrollRead == true)
        {
            dialogueManager.ShowDialogue("You heed the words from the scroll and take off the picture from the wall, revealing another safe");
            gameObject.SetActive(false);
            colourCode.SetActive(true);

        }
        Debug.Log("You see a picture frame, a large cactus stands tall in the middle of a desert");
        dialogueManager.ShowDialogue("You see a picture of a lone cactus standing amidst rolling dunes of sand");

    }

}
