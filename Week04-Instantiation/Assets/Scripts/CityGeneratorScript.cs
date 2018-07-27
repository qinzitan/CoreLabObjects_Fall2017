//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CityGeneratorScript : MonoBehaviour {

	public static int totalBuildingCount = 0;
	int stepCounter ;

	//Get access to the City Maker prefab
	public Transform cityMakerPrefab;
	//.....Building prefab
	//public Transform buildingPrefab;

	public Transform[] buildings;

	void Start(){
		stepCounter = 0;
	}

	
	// Update is called once per frame
	void Update () {

		//city maker has to walk --> move --> 
		//transform.position added by a specific number 
		//(distance between each building)
		transform.position += transform.forward * 1.5f;

		Transform buildingPrefab;

		float randomNumber = Random.Range (0f, 100f);


		if (Random.value < 0.8f) {
				buildingPrefab = buildings [0];
		} else {
				buildingPrefab = buildings [1];
		}


		//90% change: 
		if (randomNumber < 90f) {
			//Construct building --> instantiate one building at a time
			Instantiate( buildingPrefab, transform.position + transform.right, Quaternion.identity );
			Instantiate( buildingPrefab, transform.position - transform.right, Quaternion.identity );
			totalBuildingCount+=2;

			//if there're more than 500 buildings in the scene
			if (totalBuildingCount > 500) {

				//destroy the city maker
				Destroy (gameObject);
			}
		
		} 
		//10 % chance:
		else {
			int angle;

			if (Random.value < 0.3f) {
				angle = 45;
			} else if (Random.value >= 0.3f && Random.value < 6f) {
				angle = 90;
			} else {
				angle = -90;
			}

			//call a friend --> instantiate City Maker
			transform.Rotate (0f, angle, 0f);
			Instantiate (cityMakerPrefab, transform.position, transform.rotation);
			transform.Rotate (0f, -angle, 0f);
		}

		stepCounter++;

		//if more than 15 steps have been walked
		if(stepCounter > 15){
		//destroy the gameobject
			Destroy(gameObject);
		}

	}
}

