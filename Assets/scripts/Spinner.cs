using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Spinner : MonoBehaviour
{
    public enum Spindirection {
        X,
        Y,
        Z,
    }
    [SerializeField] public Spindirection spinDirectionSelected;
    public float spinSpeed = 100f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Calculate the desired rotation step
        
        float spinSpeedFixed=spinSpeed*Time.deltaTime;
        Quaternion rotationStep = Quaternion.Euler(spinDirectionSelected==Spindirection.X?spinSpeedFixed:0f,spinDirectionSelected==Spindirection.Y?spinSpeedFixed:0f, spinDirectionSelected==Spindirection.Z?spinSpeedFixed:0f);

        // Apply rotation via physics
        rb.MoveRotation(rb.rotation * rotationStep);
    }
    private void Reset()
    {
        // Check if there's already a Rigidbody
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        // Make it kinematic
        rb.isKinematic = true;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }
}
