using UnityEngine;
using UnityEngine.UI;

public class SlotControl : MonoBehaviour
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private string itemName;

    [SerializeField] private Sprite filledSprite;
    [SerializeField] private Sprite emptySprite;
    [SerializeField] private Image img;

    private void Start()
    {

    }

    public void Update()
    {
        if (inventoryManager.HasItem(itemName))
        {
            img.sprite = filledSprite;
        }
        else
        {
            img.sprite = emptySprite;
        }
    }
}
