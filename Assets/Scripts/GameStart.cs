using UnityEngine;

public class GameStart : MonoBehaviour
{
    [SerializeField] private DialogueManager dialogueManager;

    private void Start()
    {
        dialogueManager.ShowDialogue("I don't know how I got here... The last thing I remember is going to bed. I need to find a way out of here");
    }
}
