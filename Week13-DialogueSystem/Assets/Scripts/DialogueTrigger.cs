using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	//create an instance from the Dialogue Class(Dialogue.cs)
	public Dialogue myDialogue;

	//pass current dialogue to the manager
	public void TriggerDialogue(){
		DialogueManager.instance.StartDialogue(myDialogue);
	}

}
