using UnityEngine;
using TMPro;

public class LevelHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI GameLevel;

    void Update()
    {
        GameLevel.text = GameStateController.level.ToString();
    }
}
