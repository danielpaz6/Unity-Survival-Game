using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour
{
	public Transform[] waypoint;
	public float speed = 5;
	int currentWayPoint;
	Vector3 target, moveDirection;

    // Update is called once per frame
    void Update()
    {
        target = waypoint[currentWayPoint].position;
		moveDirection = target - transform.position;

		if(moveDirection.magnitude < 3) {
			currentWayPoint = ++currentWayPoint % waypoint.Length;
		}

		GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
		
		//Vector3 newDirection = Vector3.RotateTowards(transform.forward, moveDirection, 0.0f, 0.0f);
		//transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
