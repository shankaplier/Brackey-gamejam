using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wait());
        
    }

    public void Wait5seconds() 
    {
        StartCoroutine(wait());
    }

    IEnumerator wait() 
    { 
    yield return new WaitForSeconds(5);
    }
}
