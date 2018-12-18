using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public bool doorClosed = true;
    public GameObject mainFieldCamera;
    public GameObject topFieldCamera;
 
    RaycastHit hit;

    void Start()
    { 
        //mainFieldCamera.SetActive(true);
        //topFieldCamera.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 5, Color.green);
       
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision occured");

        if (collision.gameObject.name.Equals("DoubleDoor") && collision.isTrigger == true)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 15.0f) && doorClosed)
            {
                doorClosed = false;
                Debug.Log(hit.collider.gameObject.transform);
                GameObject.Find("Left").transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
                GameObject.Find("Right").transform.Translate(new Vector3(5.0f, 0.0f, 0.0f));
            }
            //mainFieldCamera.SetActive(true);
            topFieldCamera.SetActive(false);
        }
    }


    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name.Equals("DoubleDoor"))
        {
            if (doorClosed == false)
            {
                doorClosed = true;
                GameObject.Find("Left").transform.Translate(new Vector3(5.0f, 0.0f, 0.0f));
                GameObject.Find("Right").transform.Translate(new Vector3(-5.0f, 0.0f, 0.0f));
            }
            //mainFieldCamera.SetActive(true);
            topFieldCamera.SetActive(false);
        }
    }

}
