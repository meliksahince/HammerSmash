using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;
    [SerializeField] SpriteRenderer SpriteRenderer;
    public FloatingJoystick joystick;

    public float direction;
    public bool onground;
    bool moved;
    public float runSpeed;
    // Start is called before the first frame update
    void Start()
    {
        runSpeed = 4f;
        SpriteRenderer.GetComponent<SpriteRenderer>();
        rb.GetComponent<Rigidbody2D>();
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
        direction = joystick.Horizontal * runSpeed;
        rb.velocity = new Vector2(direction, rb.velocity.y);


        if (direction > 0)
        {
            moved = true;
            SpriteRenderer.flipX = true;
        }
        else
        { 
            moved = false;
            SpriteRenderer.flipX = false;
        }
        anim.SetBool("isMoved", moved);

        float verticalMove = joystick.Vertical;

        if (verticalMove >= .5f && onground)
        {
            rb.AddForce(Vector2.up * 350f); // Buraya bak
        } 

    }
}
