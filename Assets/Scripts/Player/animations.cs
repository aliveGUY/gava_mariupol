using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour
{
    private movement movement;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        movement = GetComponent<movement>();
    }

    void Update() {
        if(movement.moveDirection != Vector3.zero){
            anim.SetBool("IsMoving", true);
        } else {
            anim.SetBool("IsMoving", false);
        }

        if(Input.GetButtonDown("Jump")) {
            anim.SetBool("IsJumping", true);
        } else {
            anim.SetBool("IsJumping", false);
        }



        if(Input.GetKey(KeyCode.LeftShift)) {
            movement.speed = 8f;
            anim.SetBool("IsRunning", true);
        } else {
            movement.speed = 2f;
            anim.SetBool("IsRunning", false);
        }

        if(movement.fallingThreshold < 3 && !movement.grounded) {
            anim.SetBool("IsFalling", true);
            movement.gravityScale = 10f;
        } else {
            anim.SetBool("IsFalling", false);
            movement.gravityScale = 5;
        }

        if(movement.grounded) {
            anim.SetBool("IsGrounded", true);
            anim.SetBool("IsJumping", false);
            anim.SetBool("IsFalling", false);
        }
    }
}
