using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D rb;

    //  public GameObject blocks;
    

    float minSpeed = 1f;
    float maxSpeed = 10f;

    float speed;

    //float hue; //renk

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
    
    void Update()
    {
        Vector2 forward = new Vector2(transform.right.x,0);
        rb.MovePosition (rb.position + forward * Time.fixedDeltaTime * speed); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {

            case "Knight":
                Debug.Log("adamadegdi");
                //Destroy(GameObject.FindGameObjectWithTag("Knight"));
                DeadCheck();
                break;
            case "Weapon":
                Debug.Log("Değmedi");
                Destroy(gameObject);
                break;
            
        }
    }

    public void DeadCheck(){
      
         GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
    }
}
