using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManagerScript : MonoBehaviour {

	//persist between scenes
	//can only be instantiated once all time

	//public: accessible to other scripts/classes/objects
	//static: tied to the whole class and not to just one instance

	//get: other script/class will be able to GET it

	//private set: don't want other script/class to erase it
	//only want set the instance within this persistent manager script
	public static PersistentManagerScript Instance { get; private set;}

	//some kind of data which is stored in this class
	//and you may want to pass it to somewhere else
	public int value;

	//set the instance property as soon as the app/game starts
	//Awake() is called before Start()
	private void Awake(){

		//Check if there's nothing being stored in the Instance property?
		//-->this code is running for the first time
		//null: doesn't contain anything
		if (Instance == null) {
			Instance = this;

			//Don't destroy the gameObject this script it attached to
			//while loading a new scene
			DontDestroyOnLoad (gameObject);
		} 
		//if there's already a instance property
		//means coming back to a scene where our manager game object is firstly located
		//Unity will try to create the script again -- NO NONONONONO!!!

		//We only keep the first and original script all time
		else {
			//destroy the new object immediately 
			Destroy (gameObject);
		}
	
	}




}
