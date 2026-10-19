using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behaviors : MonoBehaviour
{
     public float moveSpeed;
    public float jumpHeight;

    public KeyCode Spacebar ;
    public KeyCode L;
    public KeyCode R ;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
 private Animator anim; 
    private bool grounded;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;// Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
    spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (Input.GetKeyDown(Spacebar) && grounded)
        {
            Jump();
        }

        if (Input.GetKey(L))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);

            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = true;
            }
        }

        if (Input.GetKey(R))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = false;
            }
        }
        anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
     anim.SetFloat("Height", GetComponent<Rigidbody2D>().velocity.y);
     anim.SetBool("Grounded", grounded);
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            WhatIsGround
        );
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
    } 

    
    }

