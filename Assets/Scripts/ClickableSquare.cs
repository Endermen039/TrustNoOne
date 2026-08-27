using UnityEngine;

public class ClickableSquare : MonoBehaviour
{
    [SerializeField] private string squareName;

    public void OnClicked()
    {
        Debug.Log("Clicked " +  squareName);

        gameObject.SetActive(false);

    }
}
