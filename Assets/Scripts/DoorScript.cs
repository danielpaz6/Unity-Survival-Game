using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
	Animator animator;
	bool doorOpen;
	void Start() {
		doorOpen = false;
		animator = GetComponent<Animator>();
	}
	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			doorOpen = true;
			animator.SetTrigger("Open");
		}
	}
	private void OnTriggerExit(Collider other) {
		if(doorOpen) {
			doorOpen = false;
			animator.SetTrigger("Close");
		}
	}
}
