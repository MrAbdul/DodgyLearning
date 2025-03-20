using UnityEngine;

public class Dropper : MonoBehaviour {
    float currentTime;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        currentTime +=Time.time;
        Debug.Log(currentTime);
        if ( currentTime >= 3) {
            rb.useGravity = true;
        }
        else if ( currentTime >= 6) {
            rb.useGravity = false;
            rb.MovePosition();
        }
        else {
            currentTime = 0;
        }
    }
}
