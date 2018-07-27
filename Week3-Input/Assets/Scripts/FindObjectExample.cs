using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindObjectExample : MonoBehaviour {

    GameObject TheCubeOnTheRightSide;
     
	// Use this for initialization
	void Start () {
        TheCubeOnTheRightSide = GameObject.Find("CubeR");
    }
	
	
	void OnMouseDown () {
        //HERE IS THE LOGIC (Human language)
        // step1: GameObject We'd like to control: TheCubeOnTheRightSide

        // step2: get MeshRenderer GameComponent of TheCubeOnTheRightSide
        MeshRenderer r =  TheCubeOnTheRightSide.GetComponent<MeshRenderer>();

        // step3: get MeshRenderer > material > color
        // step4: assign a new color to it

        r.material.color = Color.red;
    }
}
