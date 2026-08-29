using UnityEngine;
using UnityEngine.UI;

public class SafeInteractable : Interactable
{

    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private GameObject safeUI;
    [SerializeField] private BoxCollider2D safeCollider;
    [SerializeField] private CameraScroll cameraMovement;


    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("It looks like I can input some kind of code");
        safeUI.SetActive(true);
        safeCollider.enabled = false;
        cameraMovement.canMove = false;
    }
}
