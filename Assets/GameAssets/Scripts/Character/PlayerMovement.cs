using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Velocidad de movimiento
    public float movementSpeed = 2;

    private bool facingRight = false;

    private Rigidbody2D wormRB;

    public bool isGrounded = false;
    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce = 700;

    private void Awake()
    {
        wormRB = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);


        float move = Input.GetAxis("Horizontal");

        wormRB.velocity = new Vector2(move * movementSpeed, wormRB.velocity.y);

        if (move > 0 && !facingRight)
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
    }

    private void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            wormRB.AddForce(new Vector2(0, jumpForce));
        }
    }

    private void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = this.transform.localScale;
        theScale.x *= -1;
        this.transform.localScale = theScale;
    }
}
