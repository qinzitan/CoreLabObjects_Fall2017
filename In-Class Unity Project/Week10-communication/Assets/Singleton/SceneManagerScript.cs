using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneManagerScript : MonoBehaviour {

	//refer the the value textBox in the editor
	public Text valueText;

	void Start(){
		//Get access to the Instance of PersistentManagerScript
		//Because it's static, so we don't have to have a reference (Find object/get component)

		//ToString(): convert whatever to a string
		valueText.text = PersistentManagerScript.Instance.value.ToString ();
	}

	public void GoToFirstScene(){
		SceneManager.LoadScene ("First");
		//increment the value inside our persistentManagerScript instance;
		PersistentManagerScript.Instance.value++;
	}

	public void GoToSecondScene(){
		SceneManager.LoadScene ("Second");
		PersistentManagerScript.Instance.value++;
	}

}
