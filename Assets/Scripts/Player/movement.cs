using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float jumpHeight;

    private Rigidbody rb;
    private Vector3 moveDirection;

    private void Start()
    {
        Physics.gravity = new Vector3(0,-200,0);
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rb.velocity = moveDirection * speed ;

        if(moveDirection != Vector3.zero){
            Quaternion toRotaion = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotaion, rotationSpeed);
        }
        if (Input.GetButton("Jump")) {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        } 
    }
}
