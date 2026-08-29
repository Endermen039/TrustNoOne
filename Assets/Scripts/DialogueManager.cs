using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private TMP_Text dialogueText;

    public bool IsDialogueActive => dialogueText.gameObject.activeSelf;

    private bool canDismiss;

    public void ShowDialogue(string message)
    {
        dialogueText.gameObject.SetActive(true);
        dialogueText.text = message;

        canDismiss = false;
        StartCoroutine(AllowDismiss());
    }

    private IEnumerator AllowDismiss()
    {
        yield return null;
        canDismiss = true;
    }

    private void Update()
    {
        if (IsDialogueActive && canDismiss && Mouse.current.leftButton.wasPressedThisFrame)
        {
            dialogueText.gameObject.SetActive(false);
        }
    }
}
