using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExample : MonoBehaviour {

	//Get access to the prefab
	public GameObject bullet;

	//....to the posReference
	public Transform posReference;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){

			//Instantiate bullet prefab at the position we want
			//Instantiate(): three parameters
			//1. prefab
			//2. starting position
			//3. starting rotation
			Instantiate(bullet, posReference.position, posReference.rotation);

		}

	}
}
