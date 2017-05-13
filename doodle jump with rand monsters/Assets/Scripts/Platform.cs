using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
	public BoxCollider2D platformBox;
	//listens monsterhit broadcast
	// Use this for initialization
	void OnEnable () {
		Body.MonsterHit += MonsterHit;
		
	}
	void OnDisable () {
		Body.MonsterHit -= MonsterHit;
	}

	void MonsterHit(string WhatWasSent){
		if(WhatWasSent == "Dead")
		{
			platformBox.enabled = false;

		}
	
	}

}
