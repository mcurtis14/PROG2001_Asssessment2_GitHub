using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TraceyGameManager : MonoBehaviour
{
    public int totalCollectibles = 5;
    private int collected = 0;

    public TMP_Text scoreText;
    public GameObject winText;
    public GameObject losePanel;

    void Start()
    {
        Time.timeScale = 1f;
        UpdateScore();

        if (winText != null)
        {
            winText.SetActive(false);
        }

        if (losePanel != null)
        {
            losePanel.SetActive(false);
        }
    }

    public void Collect()
    {
        collected++;
        UpdateScore();

        if (collected >= totalCollectibles)
        {
            WinGame();
        }
    }

    void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Collected: " + collected + "/" + totalCollectibles;
        }
    }

    void WinGame()
    {
        if (winText != null)
        {
            winText.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        if (losePanel != null)
        {
            losePanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void ResetGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
       SceneManager.LoadScene("BackupMainMenu");
    }
}