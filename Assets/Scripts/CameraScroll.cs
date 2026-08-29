using UnityEngine;
using UnityEngine.InputSystem;


public class CameraScroll : MonoBehaviour
{
    [SerializeField] private float edgeSize = 300f;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float minX = -10;
    [SerializeField] private float maxX = 8;

    public bool canMove = true;

    void Update()
    {

        Vector3 mousePosition = Mouse.current.position.ReadValue();
        if (canMove)
        {
            if (mousePosition.x <= edgeSize)
            {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            }
            else if (mousePosition.x >= Screen.width - edgeSize)
            {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            }

        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);

        transform.position = new Vector3(
            clampedX,
            transform.position.y,
            transform.position.z
        );
        }
        else
        {
            return;
        }

    }
}
