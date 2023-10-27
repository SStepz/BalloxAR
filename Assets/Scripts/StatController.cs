using UnityEngine;
using TMPro;

public class StatController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highscore;
    [SerializeField] TextMeshProUGUI maxlevel;

    void Start()
    {
        highscore.text = GameStateController.highscore.ToString();
        maxlevel.text = GameStateController.maxlevel.ToString();
    }
}
