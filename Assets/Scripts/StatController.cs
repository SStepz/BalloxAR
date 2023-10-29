using UnityEngine;
using TMPro;

public class StatController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highscore;
    [SerializeField] TextMeshProUGUI maxlevel;

    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        maxlevel.text = PlayerPrefs.GetInt("MaxLevel", 0).ToString();
    }
}
