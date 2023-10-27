using UnityEngine;

public class RetryGame : MonoBehaviour
{
    public static void RetryBalloxAR()
    {
        GameStateController.GameReset();
        SceneController.SwitchScenes("HomeScreen");
    }
}
