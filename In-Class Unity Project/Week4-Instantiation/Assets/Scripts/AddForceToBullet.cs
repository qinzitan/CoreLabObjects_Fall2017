using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToBullet : MonoBehaviour {

	Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.AddForce (transform.forward * 1000f);
	}
	
	// Update is called once per frame
	void Update () {

		Destroy (this.gameObject, 2);

	}
}
