using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{
	public float turnSpeed = 1000;
	public float acceleration = 1000;
	Rigidbody rg;

    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		rg.AddTorque(0, h * turnSpeed * Time.deltaTime, 0);
		rg.AddForce(transform.forward * v * acceleration * Time.deltaTime);
    }
}
