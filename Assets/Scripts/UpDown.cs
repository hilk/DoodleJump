using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour {
	float platformSpeed = 2f;
	float startPoint;
	float endPointY;

	bool endPoint;

	public int UnitsToMove = 11; //how many units to jump

	void Start(){
		startPoint = transform.position.y;
		endPointY = startPoint + UnitsToMove;
	}

	// Use this for initialization
	void Update () {
		if (endPoint) 
		{
			transform.position += Vector3.up * platformSpeed * Time.deltaTime;
		} 
		else 
		{
			transform.position -= Vector3.up * platformSpeed * Time.deltaTime;
		}
	
		if (transform.position.y >= endPointY) {
			endPoint = false;
		}
		if (transform.position.y <= startPoint) {
			endPoint = true;
		}
	
}
}
