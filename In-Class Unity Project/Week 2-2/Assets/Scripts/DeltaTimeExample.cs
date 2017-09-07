using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeExample : MonoBehaviour {

    //distance, speed, time
    //distance = speed * time;

    //time: Time.deltaTime (second) - constantly check unity documentation
    //speed: 5 (meter/second)

    //distance = 5 * Time.deltaTime;

    public float speed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //5 is the speed, Time.deltaTime is the time
        float distance = speed * Time.deltaTime;
        transform.Translate(distance, 0, 0);
	}
}
