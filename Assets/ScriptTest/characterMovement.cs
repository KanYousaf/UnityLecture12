using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {

    [SerializeField] private float mSpeed;
    [SerializeField] private float JumpSpeed;

    // Use this for initialization
    void Start()
    {
        transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += transform.forward * mSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.position += transform.right * mSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.position += transform.up * JumpSpeed * Time.deltaTime * Input.GetAxis("JumpCrawl");

    }
}
