using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCameraToFollowDot : MonoBehaviour {
    private Transform mTargetTransform;
    private Vector3 vec3Velocity, mTargetPosition,offset;

    // Use this for initialization
    void Start () {
        mTargetTransform=GameObject.Find("DotOnMap").transform;
        vec3Velocity = Vector3.zero;

    }
	
	// Update is called once per frame
	void Update () {
        offset = new Vector3(0.0f, 20.0f, 0.0f);
        mTargetPosition=mTargetTransform.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, mTargetPosition, ref vec3Velocity, 15.0f * Time.deltaTime);
	}
}
