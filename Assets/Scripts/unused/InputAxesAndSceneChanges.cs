using UnityEngine.SceneManagement;

public static partial class InputAxesAndSceneChanges
{
    public static void LoadScene(string SceneNameToLoad)
    {
        PendingPreviousScene = SceneManager.GetActiveScene().name;
        SceneManager.sceneLoaded += ActivatorAndUnloader;
        SceneManager.LoadScene(SceneNameToLoad, LoadSceneMode.Additive);
    }
    static string PendingPreviousScene;
    static void ActivatorAndUnloader(Scene scene, LoadSceneMode mode)
    {
        SceneManager.sceneLoaded -= ActivatorAndUnloader;
        SceneManager.SetActiveScene(scene);
        SceneManager.UnloadSceneAsync(PendingPreviousScene);
    }
}
