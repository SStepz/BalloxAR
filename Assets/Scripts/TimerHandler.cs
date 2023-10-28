using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] float remainingTime;

    int randomindex = 0;

    void Start()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        while (randomindex == 0 || randomindex == currentScene)
        {
            randomindex = Random.Range(2, 5);
        }
    }

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0 && GameStateController.ballnumber > 0)
        {
            remainingTime = 0;
            SceneManager.LoadScene(randomindex);
            GameStateController.level += 1;
        }
        else
        {
            remainingTime = 0;
            SceneController.SwitchScenes("EndScreen");
            GameStateController.highscore = GameStateController.score;
            GameStateController.maxlevel = GameStateController.level;
        }
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        TimerText.text = string.Format("{00}", seconds);
    }
}
