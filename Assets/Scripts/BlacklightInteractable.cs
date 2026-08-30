using UnityEngine;

public class BlacklightInteractable : Interactable
{
    [SerializeField] private InventoryManager inventoryManager;
    [SerializeField] DialogueManager dialogueManager;

    public bool activeState = true;

    public override void OnInteract()
    {
        if (gameObject.name == "1_Blacklight")
        {
            Debug.Log("You picked up a blacklight");

            dialogueManager.ShowDialogue("You picked up a blacklight");

            inventoryManager.AddItem("1_Blacklight");

            gameObject.SetActive(false);

            activeState = false;
        }
    }
}
