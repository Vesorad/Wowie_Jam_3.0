using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
   
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            gameObject.SetActive(false);
        }
    }
    void Update()
    {
        
    }
}
