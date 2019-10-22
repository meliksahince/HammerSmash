using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemy : MonoBehaviour
{
    public Rigidbody2D rb;

    float minSpeed = 1f;
    float maxSpeed = 10f;

    float speed;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        Vector2 forward = new Vector2(transform.right.x, 0);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Knight":
                Destroy(GameObject.FindGameObjectWithTag("Knight"));
                break;
            case "Weapon":
                Debug.Log("değdi");
                Destroy(gameObject);
                break;
            case "Destroyer":
                Destroy(gameObject);
                break;

        }
    }
}
