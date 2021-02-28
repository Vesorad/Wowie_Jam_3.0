using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    OpenDoorKey openDoorKey;
    
    private void Start()
    {
        openDoorKey = FindObjectOfType<OpenDoorKey>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            gameObject.SetActive(false);
            openDoorKey.gameObject.SetActive(false);
        }
    }
}
