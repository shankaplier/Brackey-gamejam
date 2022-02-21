using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBoxScript : MonoBehaviour
{

    //An placeholder int for specifying which objecct is currently selected
    private int selectedObject;

    private void Update()
    {
        // Selecting an object by pressing 1, 2 and 3
        if (Input.GetKey(KeyCode.Alpha1))
        {
            selectedObject = 1;
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            selectedObject = 2;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            selectedObject = 3;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)

     
    {
        GameObject collidedObject = collision.gameObject;
        
        //On pressing the E keey the dirt will change color respective to the object
        //selected, signifying an action taking place
        if (Input.GetKey(KeyCode.E))
        {
            if (selectedObject == 1) 
            {
                collidedObject.GetComponent<SpriteRenderer>().color = new Color(253, 0, 0);
            }
            else if (selectedObject == 2)
            {
                collidedObject.GetComponent<SpriteRenderer>().color = new Color(0, 5, 253);
            }
            else if (selectedObject == 3)
            {
                collidedObject.GetComponent<SpriteRenderer>().color = new Color(253, 0, 211);
            }
        }
    }
}
