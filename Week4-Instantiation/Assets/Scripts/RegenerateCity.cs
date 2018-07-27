using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RegenerateCity : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) ) {
            Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene(scene.name, LoadSceneMode.Single);

			//Application.LoadLevel ("City Generator", LoadSceneMode.Single);
		} 
	}
}