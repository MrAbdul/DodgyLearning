using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;
    void OnCollisionEnter(Collision other) {
        if (!other.gameObject.CompareTag("Hit")) {
            score++;
            Debug.Log("You have bymped into a thing this many times: "+score);
        }
        
    }
}
