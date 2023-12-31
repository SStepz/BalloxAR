using UnityEngine;

public class ThrowBall : MonoBehaviour
{

    float startTime, endTime, swipeDistance, swipeTime;
    private Vector2 startPos;
    private Vector2 endPos;

    public float MinSwipDist = 0;
    private float BallVelocity = 0;
    private float BallSpeed = 0;
    public float MaxBallSpeed = 350;
    private Vector3 angle;

    public static bool holding = false;
    public static bool thrown = false;
    private Vector3 newPosition, resetPos;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        resetPos = transform.position;
        ResetBall();
    }

    private void OnMouseDown()
    {
        startTime = Time.time;
        startPos = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        if (!thrown)
        {
            PickupBall();
            holding = true;
        }
    }

    private void OnMouseUp()
    {
        endTime = Time.time;
        endPos = Input.mousePosition;
        swipeDistance = (endPos - startPos).magnitude;
        swipeTime = endTime - startTime;
        holding = false;

        if (swipeTime < 0.5f && swipeDistance > 30f)
        {
            //throw ball
            CalSpeed();
            CalAngle();
            rb.AddForce(new Vector3((angle.x * BallSpeed * 2), (angle.y * BallSpeed), (angle.z * BallSpeed * 2)));
            rb.useGravity = true;
            GameStateController.ballnumber -= 1;
            thrown = true;
            //Invoke("ResetBall", 2f);
        }
        else
            ResetBall();
    }

    void ResetBall()
    {
        angle = Vector3.zero;
        endPos = Vector2.zero;
        startPos = Vector2.zero;
        BallSpeed = 0;
        startTime = 0;
        endTime = 0;
        swipeDistance = 0;
        swipeTime = 0;
        holding = false;
        thrown = false;
        rb.velocity = Vector3.zero;
        rb.useGravity = false;
        transform.position = resetPos;
    }

    void PickupBall()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane * 4f;
        newPosition = Camera.main.ScreenToWorldPoint(mousePos);
        transform.localPosition = Vector3.Lerp(transform.localPosition, newPosition, 80f * Time.deltaTime);
    }

    private void CalAngle()
    {
        angle = Camera.main.ScreenToWorldPoint(new Vector3(endPos.x, endPos.y + 50f, (Camera.main.nearClipPlane + 5)));
    }

    void CalSpeed()
    {
        if (swipeTime > 0)
            BallVelocity = swipeDistance / (swipeDistance - swipeTime);

        BallSpeed = BallVelocity / 10;

        if (BallSpeed <= MaxBallSpeed)
        {
            BallSpeed = MaxBallSpeed;
        }
        swipeTime = 0;
    }
}