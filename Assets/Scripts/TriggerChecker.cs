﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Invoke("fallDown", 0.5f);
       
        }
    }
    void fallDown()
    {

        GetComponentInParent<Rigidbody>().useGravity = true;
        GetComponentInParent<Rigidbody>().isKinematic = false;
        

        Destroy(transform.parent.gameObject, 2f);
    }
}