using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    { 
        rb.AddForce(transform.forward * 300.0f);
        rb.useGravity = true;
    }

}
