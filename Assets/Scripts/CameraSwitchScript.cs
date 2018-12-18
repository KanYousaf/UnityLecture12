using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScript : MonoBehaviour {
    public GameObject mainCamera;
    public GameObject topCamera;

	// Use this for initialization
	void Start () {
        //camera position set

        cameraPositionChange(PlayerPrefs.GetInt("CameraPosition"));
        mainCamera.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        switchCamera();
	}

    //Change Camera Keyboard
    void switchCamera()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            cameraChangeCounter();
        }
    }

    //Camera Counter
    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    //Camera change Logic
    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }

        //Set camera position database
        PlayerPrefs.SetInt("CameraPosition", camPosition);

        //Set camera position 1
        if (camPosition == 0)
        {
            mainCamera.SetActive(true);
            topCamera.SetActive(false);
        }

        //Set camera position 2
        if (camPosition == 1)
        {
            topCamera.SetActive(true);          
            mainCamera.SetActive(false);
        }
    }
}
