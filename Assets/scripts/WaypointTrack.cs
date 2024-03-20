using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTrack : MonoBehaviour
{
    //Creates array from waypoint empty elements. Shows them in unity by serialziing field.
    [SerializeField]              
    private Transform[] waypoints;

    //Creates a move speed that shows in the unity editor.
    [SerializeField]
    private float moveSpeed = 2f;

    //Current waypoint the object is at.
    [SerializeField]
    private int wayPointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[wayPointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Calls move method
        Move();
    }

    //Move function that moves object from current waypoint to the next.
    void Move()
    {
         transform.position = Vector2.MoveTowards(transform.position, waypoints[wayPointIndex].transform.position, moveSpeed*Time.deltaTime);

        if(transform.position == waypoints[wayPointIndex].transform.position)
        {
           wayPointIndex++;
        }

        if(wayPointIndex == waypoints.Length)
        {
            wayPointIndex = 0;
        }
    }
}
