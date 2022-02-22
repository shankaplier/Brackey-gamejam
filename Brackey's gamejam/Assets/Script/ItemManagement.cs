using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagement : MonoBehaviour
{

    //Variables to check which sprite is currently being displayed;
    public bool daisyFunction;
    public bool lavenderFunction;
    public bool roseFunction;
    public bool tulipFunction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateObject(Sprite toBeCreated, GameObject objectPickupPosition, string Itemdisplayed)
    {
        if (objectPickupPosition != null)
        {
            objectPickupPosition.GetComponent<SpriteRenderer>().sprite = toBeCreated;
            if (Itemdisplayed == "Daisy")
            {
                daisyFunction = true;
                lavenderFunction = false;
                roseFunction = false;
                tulipFunction = false;
            }
            else if (Itemdisplayed == "Lavender")
            {
                daisyFunction = false;
                lavenderFunction = true;
                roseFunction = false;
                tulipFunction = false;
            }
            else if (Itemdisplayed == "true")
            {
                daisyFunction = false;
                lavenderFunction = false;
                roseFunction = true;
                tulipFunction = false;
            }
            else if (Itemdisplayed == "Tulip")
            {
                daisyFunction = false;
                lavenderFunction = true;
                roseFunction = false;
                tulipFunction = true;

            }
        }
        else
        {
            Debug.LogError("Hey there is no empty object named ObjectPickupPosition");
        }

    }

}
