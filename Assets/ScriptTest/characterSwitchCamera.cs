using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSwitchCamera : MonoBehaviour {
    public GameObject mainCamera;
    public GameObject topCamera;

    // Use this for initialization
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("CameraPosition"));
        changeCameraPosition(PlayerPrefs.GetInt("CameraPosition"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
        {
            switchCamera();
        }
    }

    void switchCamera()
    {
        int camCurrentChoice = PlayerPrefs.GetInt("CameraPosition");
        camCurrentChoice++;
        changeCameraPosition(camCurrentChoice);
    }

    void changeCameraPosition(int camPos)
    {
        if (camPos > 1)
        {
            camPos = 0;
        }

        PlayerPrefs.SetInt("CameraPosition", camPos);

        if (camPos == 0)
        {
            mainCamera.SetActive(true);
            topCamera.SetActive(false);
        }
        if (camPos == 1)
        {
            mainCamera.SetActive(false);
            topCamera.SetActive(true);
        }
    }
}
