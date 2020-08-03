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
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "cow")
        {
            if (other.gameObject.tag == "enemy" || other.gameObject.tag == "cow")
            {
                PlayerScoreScript.playerFood += 1;
            }

            //if (other.gameObject.tag == "figurine")
            //{
            //    PlayerScoreScript.playerScore += 1;
            //}
            //----///
            if (other.gameObject.tag == "cow")
            {
                Destroy(other.gameObject);
                Instantiate(cow2, other.transform.position, Quaternion.identity);
            }
            other.GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
        }
    }
}
