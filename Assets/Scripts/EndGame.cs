using System;
using System.Collections;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public float time = 4;
    private float timeStore = 4;

    void Start()
    {
        timeStore = time;
    }

    void Update()
    {
        if (GameStateController.ballnumber == 0)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            else
            {
                if (GameStateController.ballnumber == 0)
                {
                    //this.Invoke(() => SceneController.SwitchScenes("EndScreen"), 1f);
                    SceneController.SwitchScenes("EndScreen");
                }
            }
        }
        else
        {
            time = timeStore;
        }
    }
}

public static class Utility
{
    public static void Invoke(this MonoBehaviour mb, Action f, float delay)
    {
        mb.StartCoroutine(InvokeRoutine(f, delay));
    }

    private static IEnumerator InvokeRoutine(System.Action f, float delay)
    {
        yield return new WaitForSeconds(delay);
        f();
    }
}