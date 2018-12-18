using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour {
    
    public float mSpeed = 100.0f;
    private Rigidbody canonBallRigidBody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void FixedUpdate()
    {
        canonBallRigidBody = this.gameObject.GetComponent<Rigidbody>();
        canonBallRigidBody.AddRelativeForce(new Vector3(0.0f, 0.0f, 10.0f) * mSpeed * Time.deltaTime, ForceMode.Force);
        //canonBallRigidBody.AddRelativeForce(Vector3.left * mSpeed * Time.deltaTime, ForceMode.Impulse);
        canonBallRigidBody.AddRelativeTorque(new Vector3(10.0f, 1.0f, 0.0f) * mSpeed * Time.deltaTime);
    }
}
