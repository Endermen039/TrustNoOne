using UnityEngine;

public class KeyInteractable : Interactable
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] DialogueManager dialogueManager;

    public override void OnInteract()
    {
        if (gameObject.name == "1_Key")
        {
            Debug.Log("You picked up a key");

            dialogueManager.ShowDialogue("You picked up a key");

            inventoryManager.AddItem("1_Key");

            gameObject.SetActive(false);
        }
    }
}
