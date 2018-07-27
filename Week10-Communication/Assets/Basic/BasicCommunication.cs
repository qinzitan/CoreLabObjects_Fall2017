using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]

public class BasicCommunication : MonoBehaviour {

	public GameObject myGameObject;

	public Transform myTransform;


	Rigidbody myRigidBody;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		myGameObject.transform.position = Vector3.up * Time.time;
	
		myRigidBody.AddForce (Vector3.up * 50);
	
	}
}
