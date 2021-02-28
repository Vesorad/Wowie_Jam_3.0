using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    ScaneManager scaneManager;
    PlayerController playerController;
    void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
        scaneManager = FindObjectOfType<ScaneManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (playerController.trash==5)
        {
            SceneManager.LoadScene("TrashWin");
        }
        else
        {
            scaneManager.NextScene();
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
