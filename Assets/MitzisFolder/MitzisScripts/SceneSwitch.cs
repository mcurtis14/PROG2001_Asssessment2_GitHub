using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("MitzisScene");
    }

    // Update is called once per frame

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("BackupMainMenuScene");
    }
}
