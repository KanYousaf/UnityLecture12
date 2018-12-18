using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterosScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 meterosForce = new Vector3(-10f, 0.0f, 0.0f);
        this.gameObject.GetComponent<Rigidbody>().AddForce(meterosForce, ForceMode.Acceleration);

        Vector3 meterosTorque = new Vector3(0.25f, 0.0f, 0.0f);
        //this.gameObject.GetComponent<Rigidbody>().AddTorque(meterosForce, ForceMode.Acceleration);
        this.gameObject.GetComponent<Rigidbody>().AddRelativeTorque(meterosForce);
    }
}
