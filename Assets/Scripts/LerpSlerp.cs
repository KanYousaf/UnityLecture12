using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpSlerp : MonoBehaviour {
    [SerializeField] Transform mTransform;
    [SerializeField] float velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 targetPosition = mTransform.position;
        //Vector3 lerpPosition = Vector3.Lerp(transform.position, targetPosition, velocity * Time.deltaTime);
        //Vector3 LerpValue =  lerpPosition - transform.position;
        //Debug.Log(LerpValue);
        //transform.position= lerpPosition;

        Vector3 updatedSlerpPositionVector=Vector3.Slerp(transform.position, mTransform.position, velocity * Time.deltaTime);
        Vector3 slerpValue = updatedSlerpPositionVector-transform.position;
        Debug.Log(slerpValue);
        transform.position = updatedSlerpPositionVector;

    }
}
