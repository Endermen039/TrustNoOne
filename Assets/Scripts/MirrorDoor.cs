using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MirrorDoor : Interactable
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] private SpriteRenderer doorSpriteRenderer;
    [SerializeField] private Sprite openDoorSprite;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] Image MirrorEnding;
    [SerializeField] GameObject mirrorEnding;
    private bool opened = false;

    public override void OnInteract()
    {
        if (gameObject.name == "MirrorDoor" && opened == false)
        {
            if (inventoryManager.HasItem("1_Key"))
            {
                Debug.Log("The door was unlocked with the key");
                dialogueManager.ShowDialogue("The door creaked open and the key vanished from the lock. Your fate was chosen...");
                opened = true;
                inventoryManager.RemoveItem("1_Key");

                doorSpriteRenderer.sprite = openDoorSprite;

            }
            else
            {
                Debug.Log("The door won't budge, but you notice a slot for a key");
                dialogueManager.ShowDialogue("Similar to the other, the door won't budge without the key");
            }
        }
        else if (gameObject.name == "MirrorDoor" && opened == true)
        {
            MirrorEnding.enabled = true;
            mirrorEnding.SetActive(true);
        }

    }
}
