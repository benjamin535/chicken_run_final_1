using UnityEngine;
using UnityEngine.UI;

public class GitHubLinkOpener : MonoBehaviour
{
    public Button githubButton; // The button that will open the GitHub link

    public string githubUrl = "https://github.com/benjamin535/chicken_run_final.git";  // GitHub URL

    void Start()
    {
        // Directly assign the click action
        githubButton.onClick.AddListener(() => Application.OpenURL(githubUrl));
    }
}
