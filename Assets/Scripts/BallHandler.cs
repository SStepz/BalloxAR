using UnityEngine;
using TMPro;

public class BallHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI GameBall;

    void Update()
    {
        GameBall.text = GameStateController.ballnumber.ToString();
    }
}
