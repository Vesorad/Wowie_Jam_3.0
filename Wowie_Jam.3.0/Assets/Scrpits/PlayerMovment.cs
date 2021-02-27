using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController2D characterController;
    public Animator animator;


    float horizontalMove = 0f;
    public float runSpeed = 40f;

    bool jump = false;
    bool crouch = false;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.Find("Box") == null)
        {
            Movment();
            Jump();
            Crouch();
        }
        else
        {
            horizontalMove = 0;
            float rotation = Input.GetAxis("Horizontal") * (runSpeed / 30) * Time.deltaTime;
            transform.Translate(rotation, 0, 0);
        }
    }

    private void Movment()
    {       
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));     
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
            animator.SetBool("Jump", true);
        }
    }
    public void OnCrunching(bool isCrouching)
    {
        animator.SetBool("Crouch", isCrouching);
    }
    void Crouch()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            crouch = true;
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            crouch = false;
        }
    }
    private void FixedUpdate()
    {
        characterController.Move(horizontalMove* Time.deltaTime, crouch, jump);
        jump = false;
        
    }
    public void OnLanding()
    {
        animator.SetBool("Jump", false);
    }
}
