using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterRaycastDoor : MonoBehaviour {

    bool doorClosed = true;
    RaycastHit hit;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10, Color.red);
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Equals("Door"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 15.0f) && doorClosed == true)
            {
                doorClosed = false;
                GameObject.Find("Left").transform.Translate(-5.0f, 0.0f, 0.0f);
                GameObject.Find("Right").transform.Translate(5.0f, 0.0f, 0.0f);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("Door"))
        {
            if (doorClosed == false)
            { 
                GameObject.Find("Left").transform.Translate(5.0f, 0.0f, 0.0f);
                GameObject.Find("Right").transform.Translate(-5.0f, 0.0f, 0.0f);
                doorClosed = true;
            }
        }
    }
}
