using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaisySeedBagScript : ItemManagement
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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) 
        {
            itemManagement.CreateObject(daisySeedBag, objectPickupPosition, "Daisy");
        
        }
        
    }
}
