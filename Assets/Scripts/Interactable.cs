using UnityEngine;

public class Interactable : MonoBehaviour
{

    [SerializeField] private InventoryManager inventoryManager;

    [SerializeField] private SpriteRenderer doorSpriteRenderer;
    [SerializeField] private Sprite openDoorSprite;


    public void OnInteract()
    {
        Debug.Log("Interacted with " + gameObject.name);

        if (gameObject.name == "1_Key")
        {
            inventoryManager.AddItem("1_Key");
            // add in the UI logic here to make the key visible on the screen
            gameObject.SetActive(false);
        }

        if (gameObject.name == "1_Door")
        {
            if (inventoryManager.HasItem("1_Key"))
            {
                Debug.Log("The door was unlocked with the key");
                // replace the debug text with on screen dialogue
                inventoryManager.RemoveItem("1_Key");
                // remove the key from UI
                doorSpriteRenderer.sprite = openDoorSprite;
                
            }
            else
            {
                Debug.Log("The door won't budge, but you notice a slot for a key");
                // replace the debug text with on screen dialogue
            }
        }

        if (gameObject.name == "1_Picture")
        {
            Debug.Log("You examine the picture: it seems to be a family photo");
            // replace the debug text with on screen dialogue
        }

    }
}
