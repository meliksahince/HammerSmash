using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;

    public GameObject blocks;

    public float minSpeed = 0.2f;
    public float maxSpeed = 1f;

    float speed = 0.3f;

    float hue;

    void Start()
    {
        //SetColor(blocks);
        speed = Random.Range(minSpeed, maxSpeed);
    }

    /*void SetColor(GameObject blocks){
        if(Random.Range(0,3) != 0){
            hue += 0.2f;
            if(hue >= 1)
            {
                hue -= 1;
            }
        }
        blocks.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(hue,0.5f,0.9f);
    }*/
    
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x,transform.right.y);
        rb.MovePosition (rb.position + forward * Time.fixedDeltaTime * speed); 
    }
}
