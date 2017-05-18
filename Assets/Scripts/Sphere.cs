using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {
	Rigidbody rigidbody;
	float power = 0.0f;
	bool hasCharged = true;
	
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
	}

	public void Charge() {
		if(!hasCharged) return;
		transform.Rotate(50,0,0);
		power += 100 * Time.deltaTime;
	}

	public void Dash() {
		if(!hasCharged) return;
		rigidbody.AddForce(0,0,power,ForceMode.Acceleration);
		hasCharged = false;
	}

	public float Speed() {
		return rigidbody.velocity.magnitude;
	}

	public bool IsRapid() {
		return Speed() > 7;
	}

	public bool IsSlow() {
		return Speed() < 2;
	}

	public bool IsNormal() {
		return !IsRapid() && !IsSlow();
	}
}
