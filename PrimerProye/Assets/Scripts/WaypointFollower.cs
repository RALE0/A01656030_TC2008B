// David Santiago Vieyra García | A01656030 && José Daniel Rodríguez Cruz | A01781933

// This script is for making the traps follow a path (from A to B, and viceversa).
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    // We use an array of game objects to store the waypoints.
    [SerializeField] private GameObject[] waypoints;
    // We use an int to store the current waypoint index.
    private int currentWaypointIndex = 0;

    // We use a float to store the speed of the trap. That we will be able to change in the inspector.
    [SerializeField] private float speed = 2f;

    private void Update()
    {
        // We check if the distance between the trap and the current waypoint is less than 0.1f. 
        if(Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position)<0.1f)
        {
            // If it is, we increase the current waypoint index by 1.
            currentWaypointIndex++;
            // We check if the current waypoint index is greater than the length of the array.
            if (currentWaypointIndex >= waypoints.Length)
            {
                // If it is, we set the current waypoint index to 0. This will make the trap change position objective (waypoint).
                currentWaypointIndex = 0;
            }
        }
        // And now we move the trap towards the current waypoint. With a movetowards function. That receives the current position, the position of the waypoint, and the speed.
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
