using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour {
   [SerializeField] List<FlyAtPlayer> Spheres;
   void OnCollisionEnter(Collision other) {
      if (other.gameObject.CompareTag("Player")) {
         GetComponent<MeshRenderer>().material.color = Color.red;
         Debug.Log(other.gameObject.name);
         gameObject.tag = "Hit";
         
      }
   }
   void OnTriggerEnter(Collider other) {
      Debug.Log(other.gameObject.name);
      if (other.gameObject.CompareTag("Player")) {
         foreach (FlyAtPlayer sphere in Spheres) {
            sphere.fire();
         }
      }
   }
}
