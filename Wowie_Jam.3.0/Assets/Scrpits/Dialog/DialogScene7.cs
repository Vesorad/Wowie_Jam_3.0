using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScene7 : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;

    DialogueManager dialogueManager;
    private void Awake()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
    }
    void Start()
    {
       
        
        

    }
    
    IEnumerator EndDialog()
    {
        yield return new WaitForSeconds(1);
        dialogueManager.EndDialogue();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogueTrigger.TriggerDialogue();
        StartCoroutine(EndDialog());
    }
}
