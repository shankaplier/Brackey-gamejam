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
    //Variable to hold the seed sprite
    public Sprite Seed;
    //Variable to hols the dirt sprite
    public Sprite Dirt;
    //Variable to create a Pick up instance
    PickUp pickUP;
    
    void Awake()
    {
        //Creating a new PlayerScript to utilize the CreateObject function.
        itemManagement = new ItemManagement();
        //Creating a instance of ObjectPickupPosition.
        objectPickupPosition = GameObject.Find("ObjectPickupPosition");
        //Grabbing the component Inventory
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        //Creating a new pickUp component to utilize the PutIninventory function.
        pickUP = new PickUp();
        
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
                DirtScript dirtScript = collidedObject.GetComponent<DirtScript>();
                if (itemManagement.daisyFunction && dirtScript.DirtState == "Plain")
                {
                    collidedObject.GetComponent<SpriteRenderer>().sprite = Seed;
                    dirtScript.DirtState = "Planted";
                    dirtScript.SeedPlanted = "Daisy";
                    dirtScript.noofPlants = 0;
                }
                else if (itemManagement.lavenderFunction && dirtScript.DirtState == "Plain")
                {
                    collidedObject.GetComponent<SpriteRenderer>().sprite = Seed;
                    dirtScript.DirtState = "Planted";
                    dirtScript.SeedPlanted = "Lavender";
                    dirtScript.noofPlants = 0;
                }
                else if (itemManagement.roseFunction && dirtScript.DirtState == "Plain")
                {
                    collidedObject.GetComponent<SpriteRenderer>().sprite = Seed;
                    dirtScript.DirtState = "Planted";
                    dirtScript.SeedPlanted = "Rose";
                    dirtScript.noofPlants = 0;
                }
                else if (itemManagement.tulipFunction && dirtScript.DirtState == "Plain")
                {
                    collidedObject.GetComponent<SpriteRenderer>().sprite = Seed;
                    dirtScript.DirtState = "Planted";
                    dirtScript.SeedPlanted = "Tulip";
                    dirtScript.noofPlants = 0;
                }
                else if (itemManagement.canFunction && dirtScript.DirtState == "Planted")
                {
                    if (dirtScript.noofPlants == 0)
                    {
                        if (dirtScript.SeedPlanted == "Daisy") 
                        {
                            StartCoroutine(wait(dirtScript, 5));
                        }
                        else if (dirtScript.SeedPlanted == "Lavender")
                        {
                            StartCoroutine(wait(dirtScript, 8));
                        }
                        else if (dirtScript.SeedPlanted == "Rose")
                        {
                            StartCoroutine(wait(dirtScript, 9));
                        }
                        if (dirtScript.SeedPlanted == "Tulip")
                        {
                            StartCoroutine(wait(dirtScript, 11));
                        }
                    }

                }  
            
            }            
        }

        
            
    }


    IEnumerator wait(DirtScript dirtScript, int waitnumber)
    {
        yield return new WaitForSeconds(waitnumber);
        if (dirtScript.noofPlants == 0) 
        {
            Instantiate(dirtScript.Planttogrow, dirtScript.gameObject.transform, false);
            dirtScript.noofPlants += 1;
            dirtScript.gameObject.GetComponent<SpriteRenderer>().sprite = Dirt;
            dirtScript.DirtState = "Plain";
        }
        
    }

}
