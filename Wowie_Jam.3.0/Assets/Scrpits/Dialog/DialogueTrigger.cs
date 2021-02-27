using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
    ScaneManager scaneManager;
    DialogueManager dialogueManager;

    private void Start()
    {
        scaneManager = FindObjectOfType<ScaneManager>();
        dialogueManager = FindObjectOfType<DialogueManager>();
        
    }
    
    public void TriggerDialogue ()
	{
		FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
	}

}
