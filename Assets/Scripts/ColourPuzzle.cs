using UnityEngine;

public class ColourPuzzle : MonoBehaviour
{
    [SerializeField] private CameraScroll cameraMovement;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private BoxCollider2D puzzleCollider;
    public bool passCheck = false;
    private string currentCode = "";

    public void EnterNumber(int n)
    {
        if ((currentCode.Length >= 4))
        {
            return;
        }
        currentCode += n.ToString();
    }

    public void ClearCode()
    {
        currentCode = "";
    }

    public void SubmitCode()
    {
        if (currentCode.Length == 4 && currentCode == "2431")
        {
            gameObject.SetActive(false);
            dialogueManager.ShowDialogue("The safe opened revealing a vibrant key, it shimmered in the light");
            cameraMovement.canMove = true;
            passCheck = true;
        }
    }
    public void ExitSafe()
    {
        gameObject.SetActive(false);
        cameraMovement.canMove = true;
        puzzleCollider.enabled = true;
    }
}
