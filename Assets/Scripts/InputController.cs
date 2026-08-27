using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    
    public Vector2 ScreenPosition { get; private set; }
    public Vector2 WorldPosition { get; private set; }

    private Camera mainCamera;

    private void Awake()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
       if (Mouse.current == null)
        {
            return;
        }

        ScreenPosition = Mouse.current.position.ReadValue();

        Vector3 screenPosition = ScreenPosition;
        screenPosition.z = Mathf.Abs(mainCamera.transform.position.z);

        WorldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

    }
}
