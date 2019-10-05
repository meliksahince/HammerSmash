using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator anim;

    public float direction;
    bool moved;
    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        anim.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direction * 5f, rb.velocity.y);

        if (direction > 0)
        {
            moved = true;
            
        } 
        else moved = false;

        anim.SetBool("isMoved", moved);
    
    }
}
