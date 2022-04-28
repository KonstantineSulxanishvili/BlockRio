using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentScript : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private float speed = 4;
    private float jump = 400;

    void Start()
    {
    
     rigidbody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
         rigidbody.AddForce(Vector2.up * jump);
        }
        if(Input.GetKey(KeyCode.D))
        {
         rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
        }
        else if(Input.GetKey(KeyCode.A))
        {
         rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);
        }
        else
        {
         rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "MooshromEnemy")
        {
        Destroy(col.gameObject);
        Destroy(gameObject);
        }
        if(col.gameObject.tag == "EndWin")
        {
        print("You Win :>");
        // Destroy(col.gameObject);
        Destroy(gameObject);
        }
    }
}
