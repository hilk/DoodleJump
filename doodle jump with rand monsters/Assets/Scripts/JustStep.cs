using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustStep : MonoBehaviour {
	public float jumpHeight = 350;
	Vector3 moveDirection;
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

	moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	moveDirection = transform.TransformDirection(moveDirection);
	
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "JustStep") {
			moveDirection.y = 200;

		}

	}

}
