using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {
	GameObject[] enemies;
	public Transform MonsterOne;
	public Transform MonsterTwo;
	//public Transform MonsterTwo;

	float randomizing;

	public float spawnRate = 7f;
	float nextSpawn = 0.0f;
	public Transform player;
	float playerHeightY;
	private float spawnPlatformsTo;
	private float monsterCheck;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		monsterSpanner (-2.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		playerHeightY = player.position.y;
	
		if (playerHeightY >= monsterCheck) {
		
			monsterManager ();
		}

	}

	void monsterManager(){
		monsterCheck = player.position.y + 45;
		monsterSpanner (monsterCheck + 12);
	}


	void monsterSpanner(float floatvalue){
		spawnPlatformsTo = Random.Range (0f, 15f);
		float y= spawnPlatformsTo;
		while (y < floatvalue) {
			nextSpawn = Time.time + spawnRate;
			float randX = Random.Range (-2.23f,2.23f);
			Vector2 whereToSpan = new Vector2 (randX, y);



			randomizing = Random.Range (0f, 1f);
			if (randomizing > 0.5f) {

				Instantiate (MonsterOne, whereToSpan, Quaternion.identity);
			} 
			else {
				Instantiate (MonsterTwo, whereToSpan, Quaternion.identity);
			}

			y += Random.Range (15f,30f);
		}
		y = floatvalue;
	}


}

