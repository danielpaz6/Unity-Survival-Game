using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
	public GameObject boat;
	public GameObject boatCamera;
<<<<<<< HEAD

	
    // Start is called before the first frame update
    void Start()
    {
        
    }
=======
	public GameObject person;
	public GameObject playerStartPosition;
>>>>>>> 24cee3dd4bcb45e2f273efe73597708052959b55

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
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
>>>>>>> 24cee3dd4bcb45e2f273efe73597708052959b55
    }
}
