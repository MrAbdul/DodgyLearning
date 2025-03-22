using System.Collections;
using UnityEngine;

public class Dropper : MonoBehaviour {
    bool canDrop = false;
    [SerializeField] float dropDuration=3f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        StartCoroutine(Cooldown());

    }

    // Update is called once per frame
    void FixedUpdate() {
        if (canDrop) {
            rb.useGravity = true;
        }
        else {
            rb.useGravity = false;
            rb.linearVelocity = Vector3.zero;
            rb.MovePosition(new Vector3(-0.75f,7f,7f));
        }
        Debug.Log(canDrop.ToString());
        
    }
    IEnumerator Cooldown() {
        while (true) {
            yield return new WaitForSeconds(dropDuration);
            canDrop = true;
      
            yield return new WaitForSeconds(dropDuration);
            canDrop = false;
        }
    }
}
