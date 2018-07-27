using System.Collections;

using UnityEngine;


//hold all the information of dialogue
//pass them into the dialogue manager 
//whenever we'd like to start a new conversation

//it is not a monobehaviour class

//MARK IT AS SERIALIZABLE
//want it to show up in the inspector
//so we can edit it
[System.Serializable]
//int, float, collider, bool
public class Dialogue {

	//name
	public string name;

	//dialogue
	[TextArea(3,10)]
	public string[] sentences;

}
