using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenSound : MonoBehaviour {
    PlayerRaycast playerRaycastScript;
    AudioSource doorOpeningSound;
    bool doorCloseValue;

	// Use this for initialization
	void Start () {
        doorOpeningSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hello door close");
        //doorOpeningSound.Play();
    }
}
