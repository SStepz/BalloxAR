using UnityEngine;
using TMPro;

public class LevelHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI GameLevel;

    private int _level;

    public int Level
    {
        get { return _level; }
        set
        {
            _level = value;

            GameLevel.text = Level.ToString();

            PlayerPrefs.SetInt("Level: ", Level);
        }
    }
}
