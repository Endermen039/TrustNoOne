using UnityEngine;

public class CabinetInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] InventoryManager inventoryManager;
    [SerializeField] Sprite openCabinetSprite;
    [SerializeField] Sprite emptyCabinetSprite;
    [SerializeField] SpriteRenderer spriteRenderer;

    public override void OnInteract()
    {
        if (spriteRenderer.sprite != openCabinetSprite && spriteRenderer.sprite != emptyCabinetSprite)
        {
            spriteRenderer.sprite = openCabinetSprite;
            dialogueManager.ShowDialogue("The cabinet opened with ease where you find a knife");
        }
        else if (spriteRenderer.sprite == openCabinetSprite)
        {
            if (!inventoryManager.HasItem("1_Knife"))
            {
                inventoryManager.AddItem("1_Knife");
            }
            
            dialogueManager.ShowDialogue("You picked up the knife");
            spriteRenderer.sprite = emptyCabinetSprite;
        }
        else
        {
            dialogueManager.ShowDialogue("The cabinet is empty, only dust remains");
        }

    }
}
