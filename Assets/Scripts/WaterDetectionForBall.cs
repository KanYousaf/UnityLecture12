using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDetectionForBall : MonoBehaviour {
    public Canon mCanon;
    
    // Use this for initialization
    void Start () {
        
	}

    
    // Update is called once per frame
    void Update () {
	}

    void OnCollisionEnter(Collision collision)
    {
        //if (mGameObject.tag == "CanonBall")
        if (mCanon)
        {
            Rigidbody canonBallRigidBody = mCanon.GetComponent<Rigidbody>();
            //canonBallRigidBody.constraints = RigidbodyConstraints.FreezePosition;
            //canonBallRigidBody.GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(0.0f, 0.0f, 0.0f) * mCanon.mSpeed * Time.deltaTime);
            canonBallRigidBody.velocity = Vector3.zero;
            canonBallRigidBody.angularVelocity = Vector3.zero;
            Debug.Log(mCanon.mSpeed);
        }
    }
}
