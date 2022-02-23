using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemUI;
    public Sprite objectSprite;
    public string objectName;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //Item can be added to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemUI, inventory.slots[i].transform, false);
                    inventory.spriteOfObject[i] = objectSprite;
                    inventory.spriteName[i] = objectName;
                    Destroy(gameObject);
                    break;

                }
                

            }
        
        }
        
    }
}
