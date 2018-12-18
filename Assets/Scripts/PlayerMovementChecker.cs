using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementChecker : MonoBehaviour {
    private Vector3 priorFrameTransform;
    public bool isBeingMoved;

    public bool IsBeingMoved
    {
        get { return this.isBeingMoved; }

        set
        {
            if (this.isBeingMoved && !value)
            {
                // Transformation has stopped
                this.isBeingMoved = value;
            }
        }
    }

    // Use this for initialization
    void Start () {
        IsBeingMoved = false;
        priorFrameTransform = transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, priorFrameTransform) > 0.01f)
        {
            IsBeingMoved = true;
        }
        else
        {
            if (IsBeingMoved)
                IsBeingMoved = false;
        }
        priorFrameTransform = transform.position;
    }
}
