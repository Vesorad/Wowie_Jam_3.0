using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public bool Key;
    public int trash;
    public Text text;
    PlayerMovment playerMovment;
    AudioManager audioManager;

    private void Start()
    {
        playerMovment = FindObjectOfType<PlayerMovment>();
        audioManager = FindObjectOfType<AudioManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag =="Player")
        {
            if (collision.gameObject.tag == "Trash")
            {
                //audioManager.Play("Trash");
                //Debug.Log(collision.gameObject.name);
                trash += 1;
                text.text = trash.ToString();
            }
        }     
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Box")
        {

            if (Input.GetKey(KeyCode.E))
            {
                collision.gameObject.transform.parent = this.transform;              
            }  
        }
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (gameObject.transform.Find("Box") != null)
            {
                var box = gameObject.transform.Find("Box");
                box.transform.parent = null;
            }      
        }
    }
  
}
