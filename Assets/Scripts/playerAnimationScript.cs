using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimationScript : MonoBehaviour
{
    public playerMovement PM;

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PM.playerIsMoving && Input.GetKey(KeyCode.D))
        {
            animator.SetBool("MovingRight", true);
            animator.SetBool("isMoving", true);

            animator.SetBool("MovingLeft", false);
        } else if(PM.playerIsMoving && Input.GetKey(KeyCode.A))
        {
            animator.SetBool("MovingLeft", true);
            animator.SetBool("isMoving", true);

            animator.SetBool("MovingRight", false);
        }
        else 
        {
            animator.SetBool("isMoving",false);
        }
    }
}
