using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyRGB : MonoBehaviour {


    MeshRenderer r;

	// Use this for initialization
	void Start () {
        r = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        //================================
        //if ( rKeyIsPressed ) {
        //    ChangeTheColorToRed();
        //}

        //if (gKeyIsPressed)
        //{
        //    ChangeTheColorToGreen);
        //}

        //if (bKeyIsPressed)
        //{
        //    ChangeTheColorToBlue();
        //}
        //================================

        //if (rKeyIsPressed)
        //{
        //    ChangeTheColorToRed();
        //} else if (gKeyIsPressed){
        //    ChangeTheColorToGreen);
        //} else if (bKeyIsPressed){
        //    ChangeTheColorToBlue();
        //}


        if (Input.GetKeyDown(KeyCode.R)) {
            r.material.color = Color.red;
        } else if (Input.GetKeyDown(KeyCode.G)) {
            r.material.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            r.material.color = new Color(.4f, .85f, .10f );
        }
        
    }
}
