using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonBallScript : MonoBehaviour {
    [SerializeField] GameObject droneToFollow;
    [SerializeField] float canonBallVelocity=10.0f;
    float mSpeed = 60.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position=Vector3.Lerp(transform.position, droneToFollow.transform.position, canonBallVelocity * Time.deltaTime * mSpeed);
	}
}
