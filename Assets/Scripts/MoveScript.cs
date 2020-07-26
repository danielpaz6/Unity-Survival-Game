using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
	public int moveSpeed = 10;
	public Vector3 instantVelocity;
	float amtToMoveH;
	float amtToMoveV;
	void Start()
	{
		instantVelocity = Vector3.zero;
	}
	void Update()
	{
		Vector3 pos = transform.position;
		amtToMoveH = Input.GetAxis("Horizontal");
		amtToMoveV = Input.GetAxis("Vertical");
		transform.Translate(transform.right * amtToMoveH * Time.deltaTime * moveSpeed);
		transform.Translate(transform.forward * amtToMoveV * Time.deltaTime * moveSpeed);
		instantVelocity = transform.position - pos;
	}

}
