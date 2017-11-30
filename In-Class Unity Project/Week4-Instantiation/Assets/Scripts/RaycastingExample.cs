using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastingExample : MonoBehaviour {

	public GameObject mySphere; // assign reference in the Inspector

	// Update is called once per frame
	void Update () {
		// STEP 1: define "Ray" based on mousePosition in camera view
		Ray myRay = Camera.main.ScreenPointToRay( Input.mousePosition );

		// STEP 2: save some memory for "RaycastHit"
		RaycastHit myRayHit = new RaycastHit();

		// STEP 2.5: visualize the ray in Scene View
		Debug.DrawRay( myRay.origin, myRay.direction * 100f, Color.yellow);

		// STEP 3: shoot the raycast now
		if ( Physics.Raycast( myRay, out myRayHit, 1000f ) ) {
			Debug.Log("I'm hitting something!");
			// "RaycastHit.point" = Vector3 in world where the raycast hit
			mySphere.transform.position = myRayHit.point; 

			// INSTANTIATE A SPHERE WHEN WE HOLD MOUSE BUTTON
			if ( Input.GetMouseButton(0) ) {
			Instantiate( mySphere, myRayHit.point, Quaternion.identity );
			}

		} else {
			Debug.Log("I'm hitting nothing :( :( ");
		}

	}
}
