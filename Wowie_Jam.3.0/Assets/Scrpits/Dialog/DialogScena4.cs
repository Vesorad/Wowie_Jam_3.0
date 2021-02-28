using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScena4 : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;

    DialogueManager dialogueManager;
    void Start()
    {
        dialogueManager = FindObjectOfType<DialogueManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogueTrigger.TriggerDialogue();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dialogueManager.EndDialogue();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            dialogueTrigger.TriggerDialogue();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            dialogueManager.EndDialogue();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
