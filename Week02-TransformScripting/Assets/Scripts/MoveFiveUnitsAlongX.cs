using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFiveUnitsAlongX : MonoBehaviour {

    //Declare a variable for speed
    public float moveSpeedFloatBox;
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
        moveSpeedFloatBox = .005f;
        rotateSpeed = 4f;
	}
	
	// Update is called once per frame
	void Update () {

        float move = Input.GetAxisRaw("Vertical") * 0.2f;
        float rotate = Input.GetAxisRaw("Horizontal") * 5;

        //Debug.Log(rotate);

        transform.Translate(move, 0, 0);
        transform.Rotate(0, rotate, 0);
	}
}
