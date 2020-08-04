using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBoatScript : MonoBehaviour
{
	public GameObject boat;
	public GameObject boatCamera;
	public GameObject person;
	public GameObject playerStartPosition;

    // Update is called once per frame
    void Update()
    {
		// out of boat
        if(Input.GetKey("1")) {
			boat.GetComponent<Rigidbody>().isKinematic = false;
			boat.GetComponent<BoatScript>().enabled = true;
			boatCamera.SetActive(true);
			person.SetActive(false);
		}
		else if(Input.GetKey("2")) {
			boat.GetComponent<Rigidbody>().isKinematic = true;
			boat.GetComponent<BoatScript>().enabled = false;
			boatCamera.SetActive(false);
			person.SetActive(true);
			person.transform.position = playerStartPosition.transform.position;
		}
    }
}