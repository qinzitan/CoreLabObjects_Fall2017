using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScene : MonoBehaviour {

	ParticleSystem[] sparks;

	GameObject[] taggedGameObjects;
    
	GameObject theFirstSpark;

	// Use this for initialization
	void Start () {
		sparks = GetComponentsInChildren<ParticleSystem> ();

		taggedGameObjects = GameObject.FindGameObjectsWithTag ("Spark");
	
		theFirstSpark = GameObject.Find ("spark");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){

			//for each ParticleSystem instance in the array "sparks"
			foreach (ParticleSystem spark in sparks) {
				//do something to it
				spark.Pause ();
				spark.Emit (100);
			}
		}
			
		Debug.Log (taggedGameObjects [0].gameObject.name);


	}
}
