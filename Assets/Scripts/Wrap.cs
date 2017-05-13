using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrap : MonoBehaviour {
	
	void FixedUpdate () {
		//if player position is below -3.3 than..
		if(transform.position.x < -3.3f)
		{
			//player positiın will x(3.45f,curr y, curr z)
			transform.position = new Vector3 (3.3f, transform.position.y, transform.position.z);

		}
		//if player's pos is above 3.3 than
		else if(transform.position.x >= 3.3f)
		{
			//player positiın will x(3.3f,curr y, curr z)
			transform.position = new Vector3 (-3.3f, transform.position.y, transform.position.z);
			
		}

	}

}