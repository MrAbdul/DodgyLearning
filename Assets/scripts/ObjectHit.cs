using System;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   void OnCollisionEnter(Collision other) {
      GetComponent<MeshRenderer>().material.color=Color.red;
      Debug.Log(other.gameObject.name);
   }
   void OnTriggerEnter(Collider other) {
      Debug.Log(other.gameObject.name);
   }
}
