using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGameButton : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }
    }

    //void Start()
    //{
    //    this.GetComponent<Button>().onClick.AddListener(TogglePause);
    //}
    //public void TogglePause()
    //{
    //    Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
    //}
}
