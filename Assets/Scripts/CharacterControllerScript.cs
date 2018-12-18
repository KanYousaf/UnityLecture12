using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour {
    private float turnSpeed = 90.0f;
    private float gazeSpeed = 90.0f;
    private float jumpSpeed = 8.0f;
    private float gravity = 9.8f;

    private float speed = 10.0f;
    private float vSpeed = 0.0f;  //current vertical velocity

    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
        //transform.Rotate(Input.GetAxis("Roll") * gazeSpeed * Time.deltaTime, 0, 0);
        Vector3 velocity = transform.forward * Input.GetAxis("Vertical") * speed;
        if (GetComponent<CharacterController>().isGrounded)
        {
            vSpeed = 0.0f; // grounded character has vSpeed = 0...
            if (Input.GetKeyDown("space"))
            {
                vSpeed = jumpSpeed;
            }
        }
        //Debug.Log("Before vSpeed " + vSpeed);
        // apply gravity acceleration to vertical speed:
        vSpeed -= gravity * Time.deltaTime;
        //Debug.Log("Gravity " + gravity);
        //Debug.Log("vSpeed " + vSpeed);
        velocity.y = vSpeed; // include vertical speed in vel
                             // convert vel to displacement and Move the character:
        GetComponent<CharacterController>().Move(velocity * Time.deltaTime);
    }
}
