using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab;

    private GameObject spawnedBall;
    private GameObject objCamera;
    private Vector3 TargetPosition;

    void Start()
    {
        objCamera = GameObject.FindWithTag("MainCamera");
        TargetPosition = (objCamera.transform.forward * 0.35f) + (objCamera.transform.up * -0.2f) + objCamera.transform.position;
        if (!ThrowBall.thrown)
        {
            spawnedBall = Instantiate(BallPrefab, TargetPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        TargetPosition = (objCamera.transform.forward * 0.35f) + (objCamera.transform.up * -0.2f) + objCamera.transform.position;
        if (ThrowBall.thrown)
        {
            Destroy(spawnedBall, 3f);
        }
        else if (spawnedBall != null && !ThrowBall.holding && !ThrowBall.thrown)
        {
            spawnedBall.transform.position = TargetPosition;
        }
        if (GameStateController.ballnumber > 0 && ThrowBall.thrown)
        {
            spawnedBall = Instantiate(BallPrefab, TargetPosition, Quaternion.identity);
        }
    }
}
