using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    AudioSource myAudio;

    // Use this for initialization
    void Start () {
        myAudio = GetComponent<AudioSource>();
	}

    //the moment when collision happens
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Enter");

        //myAudio.Play();
        //Debug.Log(myAudio.isPlaying);

        //if (myAudio.isPlaying) {
        //    Debug.Log("Yes It's Playing!");
        //}


        //if myAudio is not playing
        //myAudio.isPlaying == false

        //run myAudio.Play();

        if (myAudio.isPlaying == false) {
            myAudio.Play();
        }
    }

    //lasts for a while
    void OnCollisionStay(Collision collision)
    {
        //Debug.Log("stay");
    }

    //the moment when there's no collision
    void OnCollisionExit(Collision collision)
    {
       // Debug.Log("Exit");
    }
}


