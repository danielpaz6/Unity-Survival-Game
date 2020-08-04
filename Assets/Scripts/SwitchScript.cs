using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
	public GameObject boat;
	public GameObject boatCamera;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 8f76439... Added Deep Learning feature

	
    // Start is called before the first frame update
    void Start()
    {
        
    }
<<<<<<< HEAD
=======
	public GameObject person;
	public GameObject playerStartPosition;
>>>>>>> 24cee3dd4bcb45e2f273efe73597708052959b55
=======
>>>>>>> parent of 8f76439... Added Deep Learning feature

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
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
=======
        
>>>>>>> parent of 8f76439... Added Deep Learning feature
    }
}
