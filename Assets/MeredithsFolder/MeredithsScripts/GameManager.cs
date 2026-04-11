using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;

    private int score = 0;
    public int totalCollectibles = 5;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateScoreText();
        winText.gameObject.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        UpdateScoreText();

        if (score >= totalCollectibles)
        {
            winText.gameObject.SetActive(true);
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = "Bush Tucker Collected: " + score;
    }
}
