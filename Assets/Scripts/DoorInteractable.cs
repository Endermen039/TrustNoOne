using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorInteractable : Interactable
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private SpriteRenderer doorSpriteRenderer;
    [SerializeField] private Sprite openDoorSprite;

    private bool opened = false;

    public override void OnInteract()
    {
        if (gameObject.name == "1_Door" && opened == false)
        {
            if (inventoryManager.HasItem("1_Key"))
            {
                Debug.Log("The door was unlocked with the key");
                opened = true;
                inventoryManager.RemoveItem("1_Key");

                doorSpriteRenderer.sprite = openDoorSprite;

            }
            else
            {
                Debug.Log("The door won't budge, but you notice a slot for a key");
            }
        }
        else if (gameObject.name == "1_Door" && opened == true)
        {
            SceneManager.LoadScene(2);
        }
        
    }

}
