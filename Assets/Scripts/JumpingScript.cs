using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    private bool isGrounded;
    public float jumpPower = 5f;
    public KeyCode jumpButton = KeyCode.Space;
    
    // Update is called once per frame
    void Update()
    {
       Jump(); 
    }

    void Jump(){
        if (Input.GetKeyDown(jumpButton) && isGrounded == true){
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpPower), ForceMode2D.Impulse);
            print(1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Ground"){
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision){
        if (collision.gameObject.tag == "Ground"){
            isGrounded = false;
        }
    }
}
