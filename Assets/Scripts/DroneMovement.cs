using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed =50f;
    [SerializeField] float turnSpeed = 60f;
    Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }
    void Start()
    {

    }

    void Update()
    {
        Turn();
        Thrust();

    }

    void Thrust()
    {
        
        myTransform.position+= myTransform.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        myTransform.position += myTransform.up * movementSpeed * Time.deltaTime * Input.GetAxis("UpDown");
        myTransform.position += myTransform.right * movementSpeed * Time.deltaTime * Input.GetAxis("LeftRight");
    }

    void Turn()
    {
        myTransform.Rotate(new Vector3(0.0f, 0.0f, 2.0f) * turnSpeed * Time.deltaTime * Input.GetAxis("Roll"));
    }
}



