using UnityEngine;
using UnityEngine.Rendering.Universal;

public class MirrorInteractable : Interactable
{
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] InventoryManager inventoryManager;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite portalSprite;
    [SerializeField] Sprite mirrorSprite;
    [SerializeField] GameObject originalWorldObjects;
    [SerializeField] GameObject mirrorWorldObjects;
    [SerializeField] private Light2D globalLight;

    public override void OnInteract()
    {   
        if (spriteRenderer.sprite == portalSprite)
        {
            originalWorldObjects.SetActive(true);
            mirrorWorldObjects.SetActive(false);
            globalLight.color = new Color(0.7f, 0.6f, 0.6f, 0f);
            spriteRenderer.sprite = mirrorSprite;
        }
        else if (inventoryManager.HasItem("1_Blacklight"))
        {
            dialogueManager.ShowDialogue("You used the blacklight on the mirror. Suddenly the mirror started to distort sucking you through to the other side");
            spriteRenderer.sprite = portalSprite;
            originalWorldObjects.SetActive(false);
            mirrorWorldObjects.SetActive(true);
            globalLight.color = new Color(0.49f, 0.29f, 0.29f, 0f);
            
        }
 
        else
        {
            dialogueManager.ShowDialogue("It's a mirror, you can make out your surroundings but it's quite cloudy");
        }
    

    }
}
