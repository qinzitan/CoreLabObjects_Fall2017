using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public static DialogueManager instance;


	//public string[] sentences;
	//Queue - FIFO: first in, first out
	public Queue<string> sentences = new Queue<string>();

	public Text nameText;
	public Text dialogueText;


	void Start(){
		if(instance == null){
			instance = this;
		} else if (instance != this){
			Destroy(gameObject);
		}
	}

	//StartDialogue
	public void StartDialogue(Dialogue dialogue){
		//display the NPC's name
		//Debug.Log(dialogue.name);
		nameText.text = dialogue.name;

		//clear previous sentences
		sentences.Clear();

		//push into the queue all the sentences of this dialogue
		foreach(string mySentenceHolder in dialogue.sentences){
			sentences.Enqueue(mySentenceHolder);
		}

		//display the first sentence
		DisplayNextSentence();
	}

	//DisplayNextSentence
	public void DisplayNextSentence(){
		//start from the first one

		//Check if there's still sentence in the dialoge?
		//If not EndDialogue() & return;
		if(sentences.Count == 0){
			EndDialogue();
			return;
		}

		//Get & Display the object at the beginning of the Queue(sentences)
		//Remove the object
		//Dequeue(): Get and remove at the same time

		string currentSentence = sentences.Dequeue();

		dialogueText.text = currentSentence;

		//co routine
		StopAllCoroutines ();
		StartCoroutine( TypeSentence(currentSentence) );

	}


	IEnumerator TypeSentence(string sentence){
		dialogueText.text = "";

		foreach (char letter in sentence.ToCharArray()) {
			dialogueText.text += letter;

			//yield return null;

			//function for delay
			yield return new WaitForSeconds(0.2f);
		}
	}


	//EndDialogue
	void EndDialogue(){
		Debug.Log("End of conversation");
	}

}
