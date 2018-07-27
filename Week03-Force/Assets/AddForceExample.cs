using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceExample : MonoBehaviour {

    Rigidbody rb;

    //float num;

	// Use this for initialization
	void Start () {
        //num = 5;

        rb = gameObject.GetComponent<Rigidbody>();
	}

    private void OnMouseDown()
    {
        rb.useGravity = true;
        rb.AddForce(transform.forward * 300f);
    }
}
