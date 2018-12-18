using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWayPointScript : MonoBehaviour {
    public GameObject wayPoint;
    //This is how often your waypoint's position will update to the player's position
    private float timer = 0.5f;

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            //Debug.Log("if time" + timer);
        }
        if (timer <= 0)
        {
            //Debug.Log("if <=0 time" + timer);
            //The position of the waypoint will update to the player's position
            UpdatePosition();
            timer = 0.5f;
        }
    }

    void UpdatePosition()
    {
        //The wayPoint's position will now be the player's current position.
        wayPoint.transform.position = transform.position;
    }
}
