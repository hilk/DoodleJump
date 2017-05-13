using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRigth : MonoBehaviour {
	float platformSpeed = 2f;
	bool endPoint;
	// Use this for initialization
	void Update () {
		if (endPoint) 
		{
			transform.position += Vector3.right * platformSpeed * Time.deltaTime;
		} 
		else 
		{
			transform.position -= Vector3.right * platformSpeed * Time.deltaTime;
		}
	
		if (transform.position.x >= 2.23f) {
			endPoint = false;
		}
		if (transform.position.x <= -2.23f) {
			endPoint = true;
		}
	
}
}
