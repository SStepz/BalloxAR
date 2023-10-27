using UnityEngine;
using TMPro;

public class TimerHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimerText;
    [SerializeField] float remainingTime;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
        }
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        TimerText.text = string.Format("{00}", seconds);
    }
}
