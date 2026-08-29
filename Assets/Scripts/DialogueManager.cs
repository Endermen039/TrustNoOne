using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;

    public bool IsDialogueActive => dialogueText.gameObject.activeSelf;

    public void ShowDialogue(string message)
    {
        dialogueText.gameObject.SetActive(true);
        dialogueText.text = message;
    }

    private void Update()
    {
        if (IsDialogueActive && Mouse.current.leftButton.wasPressedThisFrame)
        {
            dialogueText.gameObject.SetActive(false);
        }
    }
}
