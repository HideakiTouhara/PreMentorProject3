using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {
	Animator animator;
	Rigidbody rigidbody;

	float speed;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		rigidbody = GetComponent<Rigidbody>();
	}

	void OnTriggerEnter(Collider other) {
		var sphere = other.gameObject.GetComponent<Sphere>();
		if(!sphere) return;
		if(sphere.IsNormal()) {
			animator.SetBool("IsOpen", true);
		}

		if(sphere.IsRapid()) {
			GetComponent<Rigidbody>().velocity = new Vector3(0,0,sphere.Speed() * 10);
		}
	}


	void OnTriggerExit(Collider other) {
		var sphere = other.gameObject.GetComponent<Sphere>();
		if(!sphere) return;
		animator.SetBool("IsOpen", false);
	}
}
