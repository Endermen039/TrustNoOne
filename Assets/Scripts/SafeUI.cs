using UnityEngine;
using TMPro;

public class SafeUI : MonoBehaviour
{
    [SerializeField] private TMP_Text codeText;
    [SerializeField] private CameraScroll cameraMovement;
    [SerializeField] DialogueManager dialogueManager;
    [SerializeField] private BoxCollider2D safeCollider;


    private string currentCode = "";

    public void EnterNumber(int n)
    {
        if ( (currentCode.Length >= 4))
        {
            return;
        }
        currentCode += n.ToString();
        codeText.text = currentCode;
    }

    public void ClearCode()
    {
        currentCode = "";
        codeText.text = "";
    }

    public void SubmitCode()
    {
        if (currentCode.Length == 4 && currentCode == "1037")
        {
            gameObject.SetActive(false);
            dialogueManager.ShowDialogue("The safe opened revealing a flashlight emitting a purple hue");
            cameraMovement.canMove = true;
        }
    }
    public void ExitSafe()
    {
        gameObject.SetActive(false);
        cameraMovement.canMove = true;
        safeCollider.enabled = true;
    }
}
