using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereCollision : MonoBehaviour {
    public GameObject canonObject;
    public GameObject clusterPoint;

	// Use this for initialization
	void Start () {
        canonObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(canonObject, new Vector3(clusterPoint.transform.position.x + (10.0f * i), clusterPoint.transform.position.y, clusterPoint.transform.position.z), Quaternion.identity);
        }
        canonObject.SetActive(true);
    }
}
