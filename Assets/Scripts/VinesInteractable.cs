using UnityEngine;

public class VinesInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] InventoryManager inventoryManager;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite cutVineSprite;
    [SerializeField] BoxCollider2D safeCollider;


    public override void OnInteract()
    {
        if (spriteRenderer.sprite != cutVineSprite && !inventoryManager.HasItem("1_Knife"))
        {
            dialogueManager.ShowDialogue("Vines have overgrown in the room, there appears to be a safe behind it but you can't reach it");
        }
        else if (spriteRenderer.sprite != cutVineSprite && inventoryManager.HasItem("1_Knife"))
        {
            inventoryManager.RemoveItem("1_Knife");
            spriteRenderer.sprite = cutVineSprite;
            dialogueManager.ShowDialogue("You use the kife to cut the vines. The blade snapped on use");
            safeCollider.enabled = true;
        }
        else
        {
            return;
        }

    }
}
