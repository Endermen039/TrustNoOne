using UnityEngine;
using UnityEngine.UI;

public class SlotControl : MonoBehaviour
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private Sprite filledSprite;
    [SerializeField] private Sprite emptySprite;

    [SerializeField] private Image img;

    private void Start()
    {
        Image image = GetComponent<Image>();
    }

    public void Update()
    {
        if (inventoryManager.HasItem("1_Key"))
        {
            img.sprite = filledSprite;
        }
        else
        {
            img.sprite = emptySprite;
        }
    }
}
