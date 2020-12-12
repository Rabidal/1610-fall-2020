using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{

    public int playerSpeed = 10;
    public bool facingRight = true;
    public Rigidbody2D rigidbody2d;
    public float moveX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
     void PlayerMove()
    {
       //CONTROLS
       moveX = Input.GetAxis("Horizontal");
       if (Input.GetButtonDown("Jump"))
       {
           Jump();
       }
       //ANIMATIONS
       //PLAYER DIRECTION
       if (moveX < 0.0f && facingRight== false)
       {
           FlipPlayer();
       }
       else if (moveX>0.0f&& facingRight==true)
       {
           FlipPlayer();
       }
       //PHYSICS
       gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(moveX*playerSpeed,gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

     void Jump()
     {
         //JUMPING CODE 
         if (Input.GetKeyDown(KeyCode.Space))
         {
             float jumpVelocity = 30f;
             rigidbody2d.velocity = Vector2.up * jumpVelocity;
         }
     }

     void FlipPlayer()
     {
         facingRight = !facingRight;
         Vector2 localScale = gameObject.transform.localScale;
         localScale.x *= -1;
         transform.localScale = localScale;
     }
}
