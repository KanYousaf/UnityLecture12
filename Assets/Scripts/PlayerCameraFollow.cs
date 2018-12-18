using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraFollow : MonoBehaviour {
    public Transform targetTransform;
    private Vector3 offset;
    public float smoothing = 0.025f;
    Vector3 camAngle=new Vector3(-20.0f, 0.0f, 0.0f);
 
    // Use this for initialization
    void Start()
    {
        offset = new Vector3(-5.0f, 3.0f, 0.0f);
    }

    void LateUpdate()
    {
        Vector3 targetCamPosition = targetTransform.position + offset;
        transform.LookAt(targetTransform);
        transform.position = Vector3.Lerp(transform.position, targetCamPosition, smoothing * Time.deltaTime);
        transform.Rotate(camAngle);
    }

}
