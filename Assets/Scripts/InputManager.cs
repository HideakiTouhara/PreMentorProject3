using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour {

	[SerializeField]
	Sphere sphere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.B)) {
			SceneManager.LoadScene("Main");
		}

		if(Input.GetKey(KeyCode.Space)) {
			sphere.Charge();
		}

		if(Input.GetKeyUp(KeyCode.Space)) {
			sphere.Dash();
		}
	}
}
