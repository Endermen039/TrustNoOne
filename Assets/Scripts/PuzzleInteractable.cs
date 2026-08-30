using UnityEngine;

public class PuzzleInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private GameObject puzzleUI;
    [SerializeField] private ColourPuzzle puzzleScript;
    [SerializeField] private BoxCollider2D puzzleCollider;
    [SerializeField] private CameraScroll cameraMovement;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite emptyPuzzleSprite;
    [SerializeField] private GameObject key;
    [SerializeField] private KeyInteractable keyScript;

    public bool activeState = true;


    public override void OnInteract()
    {
        dialogueManager.ShowDialogue("There seems to be a colour code of some kind");
        puzzleUI.SetActive(true);
        puzzleCollider.enabled = false;
        cameraMovement.canMove = false;

    }

    private void Update()
    {
        if (puzzleScript.passCheck == true)
        {
            spriteRenderer.sprite = emptyPuzzleSprite;
            key.SetActive(keyScript.activeState);

        }
    }
}

