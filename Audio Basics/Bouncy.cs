using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceForce = 100f;

    public new Rigidbody rigidbody;

    public float min = 0.1f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rigidbody.velocity.magnitude < min)
        {
            // Get a random direction vector.
            Vector3 randomDirection = Random.insideUnitSphere;

            // Normalize the direction vector to make sure it has a magnitude of 1.
            randomDirection.Normalize();

            // Apply the random direction vector to the object with the bounce force.
            rigidbody.AddForce(randomDirection * bounceForce);
        }
    }
}