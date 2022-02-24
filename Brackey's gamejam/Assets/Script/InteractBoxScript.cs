using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBoxScript : ItemManagement
{
    //Variable to create an instance of PlayerScript.
    ItemManagement itemManagement;
    //Variable to hold an instance of ObjectPickupPosition.
    private GameObject objectPickupPosition;
    //Variable to get the component Inventory attached on player.
    private Inventory inventory;
    
    void Awake()
    {
        //Creating a new PlayerScript to utilize the CreateObject function.
        itemManagement = new ItemManagement();
        //Creating a instance of ObjectPickupPosition.
        objectPickupPosition = GameObject.Find("ObjectPickupPosition");
        //Grabbing the component Inventory
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && inventory.isFull[0]) 
        {
            itemManagement.CreateObject(inventory.spriteOfObject[0], objectPickupPosition, inventory.spriteName[0]);
        }
        else if (Input.GetKey(KeyCode.Alpha2) && inventory.isFull[1])
        {
            itemManagement.CreateObject(inventory.spriteOfObject[1], objectPickupPosition, inventory.spriteName[1]);
        }
        else if (Input.GetKey(KeyCode.Alpha3) && inventory.isFull[2])
        {
            itemManagement.CreateObject(inventory.spriteOfObject[2], objectPickupPosition, inventory.spriteName[2]);
        }
        else if (Input.GetKey(KeyCode.Alpha4) && inventory.isFull[3])
        {
            itemManagement.CreateObject(inventory.spriteOfObject[3], objectPickupPosition, inventory.spriteName[3]);
        }
        else if (Input.GetKey(KeyCode.Alpha5) && inventory.isFull[4])
        {
            itemManagement.CreateObject(inventory.spriteOfObject[4], objectPickupPosition, inventory.spriteName[4]);
        }


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        GameObject collidedObject = collision.gameObject;
 
        //Check what the object is
        if (Input.GetKey(KeyCode.E)) 
        {
            //On pressing the E key the dirt will change color respective to the object
            //selected, signifying an action taking place
            if (collidedObject.tag == "Dirt")
            {
                if (itemManagement.daisyFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 1);
                }
                else if (itemManagement.lavenderFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 1);
                }
                else if (itemManagement.roseFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
                }
                else if (itemManagement.tulipFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = Color.yellow;
                }
                else if (itemManagement.canFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = Color.gray;
                }
            }            
        }
    }

    

}
