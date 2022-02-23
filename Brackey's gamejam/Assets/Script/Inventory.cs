using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool[] isFull;
    public GameObject[] slots;
    public Sprite[] spriteOfObject;
    public string[] spriteName;


    // Start is called before the first frame update
    void Start()
    {
        spriteOfObject = new Sprite[slots.Length];
        spriteName = new string[slots.Length];
        isFull = new bool[slots.Length];

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
