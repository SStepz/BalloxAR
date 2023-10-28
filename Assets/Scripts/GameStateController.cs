using UnityEngine;

public class GameStateController : MonoBehaviour
{
    public static int highscore = 0;
    public static int maxlevel = 0;
    public static int score = 0;
    public static int level = 0;
    public static int ballnumber = 5;
    
    public static void GameReset()
    {
        score = 0;
        level = 0;
        ballnumber = 5;
    }
}
