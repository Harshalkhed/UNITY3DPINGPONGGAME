using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public GameObject _PlayerOnewall;
    public GameObject _PlayerTwowall;
    public GameObject _ball;
    public const float baseSpeed = 4f;
    public int scorePlayerOne = 0;
    public int scorePlayerTwo = 0;
    public GUIStyle style;
    public int winningScore = 5;
    private Vector3 ballDefaultPosition;
    private Rigidbody ballRigidbody;
    public Vector3 initialImpulse;

    private void Start()
    {
        
        ballDefaultPosition = _ball.transform.position;

        // Get the Rigidbody component of the ball.
        ballRigidbody = _ball.GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall_1")
        {
            // Increase Player Two's score.
            scorePlayerTwo++;
            Debug.Log("Player Two Score: " + scorePlayerTwo);

            // Reset the ball's position using Rigidbody.
            ResetBallPosition();
        }
        else if (collision.gameObject.name == "Wall_2")
        {
            // Increase Player One's score.
            scorePlayerOne++;
            Debug.Log("Player One Score: " + scorePlayerOne);

            // Reset the ball's position using Rigidbody.
            ResetBallPosition();
        }
    }

    private void ResetBallPosition()
    {
        // Stop the ball's movement by setting its velocity to basespeed.
        ballRigidbody.AddForce(initialImpulse * baseSpeed, ForceMode.Impulse);

        // Reset the ball's position to the default position.
        ballRigidbody.MovePosition(ballDefaultPosition);
    }
}
