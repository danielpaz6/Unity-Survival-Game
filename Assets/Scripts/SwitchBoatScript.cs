using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBoatScript : MonoBehaviour
{
	public GameObject boat;
	public GameObject boatCamera;
	public GameObject person;
<<<<<<< HEAD
	public Transform playerStartPosition;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
=======
	public GameObject playerStartPosition;
>>>>>>> e4b3659249b2609fac5e3ca8eb4273d8dee27a32

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
<<<<<<< HEAD
        
    }
}
=======
    }
}
>>>>>>> e4b3659249b2609fac5e3ca8eb4273d8dee27a32
