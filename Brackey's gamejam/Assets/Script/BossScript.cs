using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    private DialogueTrigger dialoguetrigger;

    public int notimes = 0;

    private void Awake()
    {
        dialoguetrigger = FindObjectOfType<DialogueTrigger>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        GameObject collidedObject = collision.gameObject;

        if (Input.GetKey(KeyCode.E)) 
        {
            notimes += 1;
            if (notimes == 1) 
            {
                dialoguetrigger.TriggerDialogue(0, 2);
            }
            
        }
    }
}
