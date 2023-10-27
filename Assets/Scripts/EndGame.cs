using System;
using System.Collections;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    void Update()
    {
        if (GameStateController.ballnumber == 0)
        {
            this.Invoke(() => SceneController.SwitchScenes("EndScreen"), 3f);
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