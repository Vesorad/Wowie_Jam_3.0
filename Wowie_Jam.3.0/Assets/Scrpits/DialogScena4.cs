using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScena4 : MonoBehaviour
{
    public int cos;
    public DialogueTrigger dialogueTrigger;
    void Start()
    {
        //
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        dialogueTrigger.TriggerDialogue();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
