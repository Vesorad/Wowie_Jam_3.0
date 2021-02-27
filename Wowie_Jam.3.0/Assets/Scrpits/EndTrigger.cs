using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    ScaneManager scaneManager;
    void Start()
    {
        scaneManager = FindObjectOfType<ScaneManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scaneManager.NextScene();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
