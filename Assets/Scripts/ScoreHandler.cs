using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI GameScore;

    private int _score;

    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;

            GameScore.text = Score.ToString();

            PlayerPrefs.SetInt("Score: ", Score);
        }
    }
}
