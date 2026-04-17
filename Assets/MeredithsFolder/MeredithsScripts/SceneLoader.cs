using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("BackupMainMenuScene");
    }

    public void LoadMeredithScene()
    {
        SceneManager.LoadScene("MeredithScene");
    }
}