using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 2;
    public float rotationSpeed = 10;
    public float jumpHeight = 3;
    public float gravityScale = 5;
    [HideInInspector]
    public bool grounded = true;
    [HideInInspector]
    public bool jumped = false;
    [HideInInspector]
    public float fallingThreshold;
    [HideInInspector]
    public Rigidbody rb;
    [HideInInspector]
    public Vector3 moveDirection;
    private float jumpForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }    

    private void FixedUpdate()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.MovePosition(transform.position + moveDirection * Time.deltaTime * speed);
        rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
        fallingThreshold = rb.velocity.y;

        if (Input.GetButtonDown("Jump") && grounded == true) {
            jumpForce = Mathf.Sqrt(jumpHeight * -2 * (Physics.gravity.y * gravityScale));
            rb.AddForce(new Vector3(0,jumpForce,0), ForceMode.Impulse );
            grounded = false;
            jumped = true;
        } else {
            jumped = false;
        }

        if(moveDirection != Vector3.zero){
            Quaternion toRotaion = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotaion, rotationSpeed);
        }
    }

    private void OnCollisionEnter(Collision c) {
        if(c.collider.gameObject.layer == 3) {
            grounded = true;
        }
    }
}
