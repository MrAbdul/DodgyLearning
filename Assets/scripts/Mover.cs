using UnityEngine;

public class Mover : MonoBehaviour {

    [SerializeField] float moveSpeed =15f;

    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate() {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0.0f;
        float zValue = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(xValue, yValue, zValue)*moveSpeed;
        rb.linearVelocity=movement;
    }
}
