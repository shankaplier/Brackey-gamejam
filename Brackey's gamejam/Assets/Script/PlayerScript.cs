using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Movement Variables to check which direction the player is moving in.
    private bool keyUp;
    private bool keyDown;
    private bool keyRight;
    private bool keyLeft;

    //Number of keys to check how many keys are pressed to prevent movement errors.
    private int noKeys = 0;

    //Variable for reference to rigidbody2d attached to player.
    private Rigidbody2D rb2d;

    //Variable to adjust movement speed if needed
    [SerializeField] int movementSpeedVertical = 450;
    [SerializeField] int movementSpeedHorizontal = 450;
    
    void Start()
    {
        // Set rb2d to RigidBody2D component of player.
        rb2d = GetComponent<Rigidbody2D>();
        // Set gravity on character to 0.
        rb2d.gravityScale = 0;
        //Sett linear drag to 10
        rb2d.drag = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // Set Movement variables to true or false depending the button pressed down.
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            keyDown = true;
            noKeys += 1;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))  
        {
            keyDown = false;
            noKeys -= 1;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            keyUp = true;
            noKeys += 1;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            keyUp = false;
            noKeys -= 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            keyLeft = true;
            noKeys += 1;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            keyLeft = false;
            noKeys -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            keyRight = true;
            noKeys += 1;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            keyRight = false;
            noKeys -= 1;
        }
    }

    private void FixedUpdate()
    {
        if (keyUp == true && noKeys == 1) 
        {
            rb2d.AddForce(Vector2.up * movementSpeedVertical * Time.deltaTime, ForceMode2D.Force);
            
        }
        else if (keyDown == true && noKeys == 1)
        {
            rb2d.AddForce(Vector2.down * movementSpeedVertical * Time.deltaTime, ForceMode2D.Force);
        }
        else if (keyRight == true && noKeys == 1)
        {
            rb2d.AddForce(Vector2.right * movementSpeedHorizontal * Time.deltaTime, ForceMode2D.Force);
        }
        else if (keyLeft == true && noKeys == 1)
        {
            rb2d.AddForce(Vector2.left * movementSpeedHorizontal * Time.deltaTime, ForceMode2D.Force);
        }

    }

    
}
