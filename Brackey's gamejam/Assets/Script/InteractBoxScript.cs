using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBoxScript : MonoBehaviour
{
    //Variables to change the position of interactBoxes with respect to player
    [SerializeField] float offsetY;
    private Vector3 parentPosition;

    private void Awake()
    {
        parentPosition = GetComponentInParent<Transform>().position;
    }

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, parentPosition.y + offsetY, transform.position.z);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I'm hitting something dude!");
    }
}
