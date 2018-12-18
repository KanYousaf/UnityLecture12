using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    private GameObject doubleDoorGO;
    private Transform mTarget;
    private Transform mTransform;
    private float moveSpeed = 3.0f;
    private float rotationSpeed = 3.0f;

    void Awake()
    {
        mTransform = transform;
    }

    void Start()
    {
        mTarget = GameObject.Find("CharacterWayPointZombies").transform;
    }

    void Update()
    {
        Vector3 lookDirection = mTarget.position - mTransform.position;
        lookDirection.y = 0;
        mTransform.rotation = Quaternion.Slerp(mTransform.rotation, Quaternion.LookRotation(lookDirection), rotationSpeed * Time.deltaTime);
        mTransform.position += mTransform.forward * moveSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("DoubleDoor"))
        {
            other.isTrigger = false;
        }
    }
}
