using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hydrant : MonoBehaviour
{
    public Animator animator;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="Player")
        {
            animator.SetBool("Fall", true);
        }
    }
}
