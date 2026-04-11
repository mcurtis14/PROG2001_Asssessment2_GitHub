using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI itemText;

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
        itemText.text = "";
    }

    public void AddScore(string itemName)
    {
        score++;
        UpdateScoreText();

        itemText.text = "Collected: " + itemName;

        Invoke("ClearItemText", 2f);

        if (score >= totalCollectibles)
        {
            winText.gameObject.SetActive(true);
        }
    }

    void ClearItemText()
    {
        itemText.text = "";
    }

    void UpdateScoreText()
    {
        scoreText.text = "Bush Tucker Collected: " + score;
    }
}
