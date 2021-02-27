using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    PlayerController playerController;
    public enum color {None ,Red, Yellow, Blue};
   public color ColorTag;
    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="Player")
        {
            gameObject.SetActive(false);
            playerController.SetActiveKey(ColorTag.ToString());
        }
    }
}
