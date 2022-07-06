using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    private Vector3 x ,y;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        x = new Vector3(transform.forward.x * Input.GetAxis("Vertical"), 0, transform.forward.z * Input.GetAxis("Vertical"));
        y = new Vector3(transform.right.x * Input.GetAxis("Horizontal"), 0, transform.right.z * Input.GetAxis("Horizontal"));
        rb.velocity = (x + y) * speed;
    }
}
