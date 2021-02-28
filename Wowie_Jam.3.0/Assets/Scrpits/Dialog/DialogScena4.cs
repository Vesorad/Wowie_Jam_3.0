using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScena4 : MonoBehaviour
{
    public DialogueTrigger dialogueTrigger;
    public DialogueTrigger dialogueTrigger2;
    PlayerController playerController;

    DialogueManager dialogueManager;
    void Start()
    {
        if (FindObjectOfType<PlayerController>() !=null)
        {
            playerController = FindObjectOfType<PlayerController>();
        }
        
        dialogueManager = FindObjectOfType<DialogueManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (FindObjectOfType<PlayerController>() != null)
        {
            if (playerController.trash == 5)
            {
                dialogueTrigger2.TriggerDialogue();
            }
            else
            {
                dialogueTrigger.TriggerDialogue();
            }
        }
        else
        {
            dialogueTrigger.TriggerDialogue();
        }
       
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
