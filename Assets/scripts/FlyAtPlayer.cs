using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float moveSpeed;
    Rigidbody rb;
    MeshRenderer meshRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rb.useGravity = false;
        
    }

    public void fire() {
        // Compute direction toward the player's *current* position
        meshRenderer.enabled = true;
        rb.useGravity = true;
        Vector3 direction = (player.transform.position - transform.position).normalized;

        // Assign velocity once, so it "throws" the sphere toward the player
        rb.linearVelocity = direction * moveSpeed;
    }
    private void Reset()
    {
        // Check if there's already a Rigidbody
         rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody>();
        }
        // Make it kinematic
        rb.isKinematic = false;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.interpolation = RigidbodyInterpolation.Interpolate;
    }
}
