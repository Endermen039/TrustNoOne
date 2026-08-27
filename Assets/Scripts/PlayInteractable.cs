using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayInteractable : Interactable
{
    public override void OnInteract()
    {
        if (gameObject.name == "PlayButton")
        {
            SceneManager.LoadScene(1);
        }
        else if (gameObject.name == "ExitButton")
        {
            Application.Quit();
        }
    }
}
