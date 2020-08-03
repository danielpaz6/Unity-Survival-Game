using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasterScript : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward), Color.green);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward) , out hit, 6))
        {
            Debug.Log("Hit");

            if (hit.collider.gameObject.name == "Guy" || hit.collider.gameObject.name == "Asi" || hit.collider.gameObject.name == "Isreal") {
                Debug.Log("Hit1");
                hit.collider.GetComponent<AudioSource>().Play();
            }
            //Destroy(GetComponent<Rigidbody>());
            //float distanceToGround = hit.distance;
            //Debug.Log(distanceToGround);

            if (hit.collider.gameObject.tag == "Fire")
            {
                Debug.Log("Hit2");
                hit.collider.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }

}
