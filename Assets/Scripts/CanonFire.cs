using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonFire : MonoBehaviour {
    [SerializeField] GameObject droneObjectAsTarget;
    [SerializeField] Vector3 canonBallVelocity;

  

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position=Vector3.SmoothDamp(transform.position, droneObjectAsTarget.transform.position, ref canonBallVelocity, 20.0f);
       // transform.position = Vector3.Lerp(transform.position, droneObjectAsTarget.transform.position, 0.25f * Time.deltaTime);
    }

    void FixedUpdate()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-10.0f, 0.0f, 0.0f), ForceMode.Acceleration);
        this.gameObject.GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(-0.25f, 0.0f, 0.0f));
    }
        
}
