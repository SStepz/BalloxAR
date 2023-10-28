using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static int multiplier = 1;
    public static int ballrate = 50;
    public static int checker = 0;

    void Start()
    {
        checker = 0;
        if (GameStateController.level == 0)
        {
            ballrate = 50;
            multiplier = 1;
        }
        else if (GameStateController.level < 4)
        {
            ballrate = 60;
            multiplier = 1;
        }
        else if (GameStateController.level < 7)
        {
            ballrate = 160;
            multiplier = 2;
        }
        else if (GameStateController.level < 10)
        {
            ballrate = 270;
            multiplier = 3;
        }
        else
        {
            ballrate = 400;
            multiplier = 4;
        }
    }

    void Update()
    {
        if (checker >= ballrate)
        {
            GameStateController.ballnumber += 1;
            checker = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box")
        {
            GameStateController.score += 10 * multiplier;
            checker += 10 * multiplier;
        }
        else if (other.gameObject.tag == "SBox")
        {
            GameStateController.score += 20 * multiplier;
            checker += 20 * multiplier;
        }
    }
}
