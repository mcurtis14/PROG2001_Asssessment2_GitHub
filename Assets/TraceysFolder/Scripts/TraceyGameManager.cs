using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TraceyGameManager : MonoBehaviour
{
    public int totalCollectibles = 5;
    private int collectedCount = 0;
    private bool gameEnded = false;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;

    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject instructionsPanel;

    public AudioSource collectSound;
    public AudioSource winSound;
    public AudioSource loseSound;

    void Start()
    {
        Time.timeScale = 0f;
        collectedCount = 0;
        gameEnded = false;

        if (scoreText != null)
            scoreText.gameObject.SetActive(true);

        if (winPanel != null)
            winPanel.SetActive(false);

        if (losePanel != null)
            losePanel.SetActive(false);

        if (instructionsPanel != null)
            instructionsPanel.SetActive(true);

        UpdateScoreUI();
    }

    public void StartGame()
    {
        Time.timeScale = 1f;

        if (instructionsPanel != null)
            instructionsPanel.SetActive(false);
    }

    public void Collect()
    {
        if (gameEnded) return;

        collectedCount++;

        if (collectSound != null)
            collectSound.Play();

        UpdateScoreUI();

        if (collectedCount >= totalCollectibles)
            WinGame();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Collected: " + collectedCount + "/" + totalCollectibles;
    }

    public void WinGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        if (winSound != null)
            winSound.Play();

        if (scoreText != null)
            scoreText.gameObject.SetActive(false);

        if (instructionsPanel != null)
            instructionsPanel.SetActive(false);

        if (losePanel != null)
            losePanel.SetActive(false);

        if (winPanel != null)
            winPanel.SetActive(true);

        if (finalScoreText != null)
            finalScoreText.text = "Final Score: " + collectedCount + "/" + totalCollectibles;

        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        if (loseSound != null)
            loseSound.Play();

        if (scoreText != null)
            scoreText.gameObject.SetActive(false);

        if (instructionsPanel != null)
            instructionsPanel.SetActive(false);

        if (winPanel != null)
            winPanel.SetActive(false);

        if (losePanel != null)
            losePanel.SetActive(true);

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
        SceneManager.LoadScene("BackupMainMenuScene");
    }
}