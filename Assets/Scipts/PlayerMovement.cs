using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement: MonoBehaviour
{
    public float moveSpeed = 5f;    
    public float jumpForce = 8f;   
    public Rigidbody rb;           

    private bool isGrounded;       
    private bool canJump = true;    

    void Update()
    {
       
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.1f);

    
        float moveInput = Input.GetAxisRaw("Horizontal");
        Vector3 moveDirection = new Vector3(moveInput, 0f, 0f).normalized;
        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, 0f);

      
        if (isGrounded && canJump && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0f);
            canJump = false; 
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
        }
    }
}