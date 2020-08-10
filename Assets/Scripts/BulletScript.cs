using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int bulletSpeed;
    long time;
    public GameObject cow2;

    void Start()
    {
        time = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
    }

    // Update is called once per frame
    void Update()
    {
        float amtToMove = bulletSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * amtToMove);
        //   if (transform.position.y > 15 || transform.position.x > 800) {

       long time2 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        if (time2-time>3000) {
            Debug.Log("destroy1");
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "cow")
        {
            PlayerScoreScript.playerFood += 1;
            other.GetComponent<AudioSource>().Play();
            Vector3 pos = other.transform.position;
            Destroy(other.gameObject);

            if (other.gameObject.tag == "cow")
            {
                Instantiate(cow2,pos , Quaternion.identity);
            }

                Debug.Log("Object Destroyed!");
        }
    }
}
