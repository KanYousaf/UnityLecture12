using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCollisionDetection : MonoBehaviour {
    public GameObject meteorPrefab;
    public GameObject clusterObject;


    // Use this for initialization
    void Start () {
 
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        Vector3 clusterPoint = clusterObject.transform.position;
        for (int i = 0; i < 200; i++)
        {
            //Instantiate(meteorPrefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
            Instantiate(meteorPrefab, new Vector3(clusterObject.transform.position.x, clusterObject.transform.position.y, clusterObject.transform.position.z + (10.0f * i)), Quaternion.identity);
            Debug.Log(i);
        }
        meteorPrefab.SetActive(true);

    }
}
