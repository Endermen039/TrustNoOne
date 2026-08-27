using UnityEngine;
using UnityEngine.InputSystem;

public class ClickManager : MonoBehaviour
{

    [SerializeField] private InputController inputController;

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 cursorPosition = inputController.WorldPosition;

            RaycastHit2D hit = Physics2D.Raycast(
                cursorPosition, Vector2.zero
            );

            if (hit.collider != null)
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    interactable.OnInteract();
                }
            }
            
        }
    }
}
