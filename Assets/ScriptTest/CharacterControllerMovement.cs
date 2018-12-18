using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerMovement : MonoBehaviour {
    private float movementSpeed = 10.0f;
    private float rotationAngle = 90.0f;
    private float vSpeed = 0.0f;
    private float jumpSpeed = 8.0f;
    private float gravity = 9.8f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,Input.GetAxis("Horizontal") * rotationAngle * Time.deltaTime, 0);
        Vector3 velocity= transform.forward * Input.GetAxis("Vertical") * movementSpeed ;

        if (GetComponent<CharacterController>().isGrounded)
        {
            vSpeed = 0.0f;
            if (Input.GetKeyDown("space"))
            {
                vSpeed = jumpSpeed;
            }
        }

        vSpeed -= gravity * Time.deltaTime;
        velocity.y = vSpeed;

        GetComponent<CharacterController>().Move(velocity * Time.deltaTime);

	}
}
