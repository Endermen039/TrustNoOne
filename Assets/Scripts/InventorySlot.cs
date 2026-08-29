using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private string itemName;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite itemSprite;


    private void Start()
    {
        spriteRenderer.enabled = true;
    }

    private void Update()
    {
        if (inventoryManager.HasItem(itemName))
        {
            spriteRenderer.sprite = itemSprite; 
            spriteRenderer.enabled = true;
        }
    }
}
