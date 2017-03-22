using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Nucleon class for spheres that will be attracted to the center of the scene
[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour {

    public float attractionForce;

    Rigidbody body;

    void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        body.AddForce(transform.localPosition * -attractionForce);
    }

  
}
