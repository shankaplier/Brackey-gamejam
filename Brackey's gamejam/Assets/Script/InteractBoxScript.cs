using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBoxScript : ItemManagement
{
    //Variable to create an instance of PlayerScript.
    ItemManagement itemManagement;
    //Variable to hold the sprite of daisyseedbag.
    public Sprite daisySeedBag;
    //Variable to hold an instance of ObjectPickupPosition.
    private GameObject objectPickupPosition;

    void Awake()
    {
        //Creating a new PlayerScript to utilize the CreateObject function.
        itemManagement = new ItemManagement();
        //Creating a instance of ObjectPickupPosition.
        objectPickupPosition = GameObject.Find("ObjectPickupPosition");

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) && GameObject.Find("Daisybutton(Clone)") != null) 
        {
            itemManagement.CreateObject(daisySeedBag, objectPickupPosition, "Daisy");
        }
        

    }


    private void OnTriggerStay2D(Collider2D collision)

     
    {
        GameObject collidedObject = collision.gameObject;
        Debug.Log(collidedObject.tag);


        //Check what the object is
        if (Input.GetKey(KeyCode.E)) 
        {
            //On pressing the E key the dirt will change color respective to the object
            //selected, signifying an action taking place
            if (collidedObject.tag == "Dirt")
            {
                if (itemManagement.daisyFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(253, 0, 0);
                }
                else if (itemManagement.lavenderFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(0, 5, 253);
                }
                else if (itemManagement.roseFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(253, 0, 211);
                }
                else if(itemManagement.tulipFunction)
                {
                    collidedObject.GetComponent<SpriteRenderer>().color = new Color(207, 203, 11, 255);
                }
            }

            
        }


    }
         
}
