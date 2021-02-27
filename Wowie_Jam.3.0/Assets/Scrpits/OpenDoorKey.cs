using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorKey : MonoBehaviour
{
    PlayerController playerController;
    public enum color { None, Red, Yellow, Blue };
    public color ColorTag;
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player")
        {
            if (true)
            {

            }
            if (playerController.redKey)
            {
                gameObject.SetActive(false);
            }
            
        }
    }
}
