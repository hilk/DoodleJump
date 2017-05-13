using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
 
//makes broadcast to another scprit
public class Body : MonoBehaviour {
	public static Action<string> MonsterHit; 
	public Movement2D isGroundedScript;


	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "Monster") {
			isGroundedScript.grounded = false;


		
			if (MonsterHit != null) {
				MonsterHit("Dead");
			}
		}
	}
}
