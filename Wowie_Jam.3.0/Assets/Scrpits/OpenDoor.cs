using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Box")
        {
            door.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Box")
        {
            door.SetActive(true);
        }
    }
}
