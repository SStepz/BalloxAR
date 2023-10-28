using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab;

    private GameObject spawnedBall;
    private GameObject objCamera;
    private Vector3 SpawnPosition;

    void Start()
    {
        objCamera = GameObject.FindWithTag("MainCamera");
        SpawnPosition = (objCamera.transform.forward * 0.35f) + (objCamera.transform.up * -0.2f) + objCamera.transform.position;
        if (!ThrowBall.thrown)
        {
            spawnedBall = Instantiate(BallPrefab, SpawnPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        if (ThrowBall.thrown)
        {
            Destroy(spawnedBall, 3f);
        }
        if (GameStateController.ballnumber > 0 && ThrowBall.thrown)
        {
            SpawnPosition = (objCamera.transform.forward * 0.35f) + (objCamera.transform.up * -0.2f) + objCamera.transform.position;
            spawnedBall = Instantiate(BallPrefab, SpawnPosition, Quaternion.identity);
        }
    }
}
