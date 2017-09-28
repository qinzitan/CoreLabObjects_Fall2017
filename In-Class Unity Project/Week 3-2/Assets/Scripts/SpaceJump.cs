using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceJump : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}

    private void Update()
    { 
        if (Input.GetButtonDown("MyJumpButton") ) { 
            rb.AddForce(transform.up * 300.0f);
            rb.useGravity = true;
        }


    }

    //void OnMouseDown()
    //{
    //    rb.AddForce(transform.up * 300.0f);
    //    rb.useGravity = true;
    //}
}
