using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI GameScore;

    void Update()
    {
        GameScore.text = GameStateController.score.ToString();
    }
}
