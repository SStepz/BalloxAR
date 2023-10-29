using UnityEngine;
using TMPro;

public class EndController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI level;

    void Start()
    {
        score.text = GameStateController.score.ToString();
        level.text = GameStateController.level.ToString();
        CheckHighScore();
        CheckMaxLevel();
    }

    void CheckHighScore()
    {
        if (GameStateController.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", GameStateController.score);
        }
    }

    void CheckMaxLevel()
    {
        if (GameStateController.level > PlayerPrefs.GetInt("MaxLevel", 0))
        {
            PlayerPrefs.SetInt("MaxLevel", GameStateController.level);
        }
    }
}