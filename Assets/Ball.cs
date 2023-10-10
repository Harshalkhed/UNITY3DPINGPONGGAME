using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 initialImpulse;
    private Rigidbody _rigidbody;
    public const float baseSpeed = 4f;
    public float accelerationRate = 2f; // Adjust this value to control the acceleration.
    public float maxSpeed = 50f; // Maximum speed for the ball.

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        AddStartingForce();
    }

    private void AddStartingForce()
    {
        _rigidbody.AddForce(initialImpulse * baseSpeed, ForceMode.Impulse);
    }

    public void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.name=="Wall_3"|| collision.gameObject.name == "Wall_4"||
            collision.gameObject.name == "Player1"||collision.gameObject.name == "Player2")


        {
            // Calculate the current speed.
            float currentSpeed = _rigidbody.velocity.magnitude;

            // Gradually increase the velocity of the ball if it's below the maxSpeed.
            if (currentSpeed < maxSpeed)
            {
                _rigidbody.velocity += _rigidbody.velocity.normalized * accelerationRate * Time.deltaTime;
            }

        }
        
    }
}
