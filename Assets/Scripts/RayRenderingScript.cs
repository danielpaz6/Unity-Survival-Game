using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayRenderingScript : MonoBehaviour
{
    private LineRenderer lr;

    void Start()
    {
        lr = GetComponent<LineRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        lr.enabled = false;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit)) {
            if (hit.collider.tag=="enemy" || hit.collider.tag == "cow")
            {
                lr.enabled = true;
                lr.SetPosition(1, new Vector3(0, 0, hit.distance));
            }
            else
            {
                lr.enabled = false;
            }
        }
        
    }
}
