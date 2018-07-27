using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empty : MonoBehaviour {
    float num = 5;
	// Use this for initialization
	void Start () {
        float num = 2;
        Debug.Log(num);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("this is Update:" + num);
	}
}
