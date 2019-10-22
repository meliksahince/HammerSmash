using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroudCheck : MonoBehaviour
{
    public CharacterMovement cm;

    // public GameObject ulasilacakGo; aşağıdaki ulaşılacakGo yu kullanmak istediğimiz zaman bunu yazıyoruz.
    public LayerMask groundLayer;
    public bool isGround;
    public float playerY;

    void Start()
    {
        playerY = GetComponent<CapsuleCollider2D>().bounds.extents.y;
        cm = transform.root.GetComponent<CharacterMovement>(); //en tepeye gider. En performanslı yol budur. // root en üst - parents bir üst 

        // ulasilacakGo.GetComponent<CharacterControllerold>(); // elle gameobject sürükleyerek.

        //cc = GameObject.Find("0").GetComponent<CharacterControllerold>(); // tüm gameobjectler arasında arama yapar ve adı sıfır olana bakar. En performanssız yol budur.


    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{

    //    cc.onground = true;
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    cc.onground = false;
    //}

    void Update()
    {
        cm.onground = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y - playerY), .1f, groundLayer);

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(new Vector2(transform.position.x, transform.position.y - playerY), .1f);
    }
}
