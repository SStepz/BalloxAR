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
    }
}