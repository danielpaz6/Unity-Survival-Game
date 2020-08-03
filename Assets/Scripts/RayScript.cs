using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour
{
    // Start is called before the first frame update
    int layerMask = (1 << 8) | (1 << 9);
    
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, layerMask)) {
            hit.collider.GetComponent<Renderer>().material.color = Color.white;
        }

    }
}
