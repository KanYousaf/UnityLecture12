using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieToFollowGameCharacter : MonoBehaviour {
    private Transform mTarget; 
    private float moveSpeed = 3.0f;
    private float rotationSpeed = 3.0f;

    // Use this for initialization
    void Start () {
        mTarget = GameObject.FindGameObjectWithTag("PlayerX").transform;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 lookDirection = mTarget.position - transform.position;
        lookDirection.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), rotationSpeed * Time.deltaTime);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;

    }
}
