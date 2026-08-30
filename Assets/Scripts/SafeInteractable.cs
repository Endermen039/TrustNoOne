using System;
using UnityEngine;
using UnityEngine.UI;

public class SafeInteractable : Interactable
{

    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private GameObject safeUI;
    [SerializeField] private SafeUI safeUIScript;
    [SerializeField] private BoxCollider2D safeCollider;
    [SerializeField] private CameraScroll cameraMovement;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite emptySafeSprite;
    [SerializeField] private GameObject blacklight;
    [SerializeField] private BlacklightInteractable blacklightScript;


    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("It looks like I can input some kind of code");
        safeUI.SetActive(true);
        safeCollider.enabled = false;
        cameraMovement.canMove = false;
        
    }

    private void Update()
    {
        if (safeUIScript.passCheck == true)
        {
            spriteRenderer.sprite = emptySafeSprite;
            blacklight.SetActive(blacklightScript.activeState);

        }
    }
}
