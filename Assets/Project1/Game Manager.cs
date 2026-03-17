using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject Zombie;
    public GameObject Coin;
    public int Score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AddScore(int amount)
    {
        Score += amount;
        UpdateScore();
    }
    public TextMeshPro ScoreText;
    public void UpdateScore()
    {
        ScoreText.text = "Score:" + Score;
    }

    void Start()
    {
        UpdateScore();
    }
}

    // Update is called once per frame
    
