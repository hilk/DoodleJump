using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed;
	public Monster monster;


	void Start(){
		speed = 7f;
	}

	void Update(){
		Vector2 pos = transform.position;
		pos = new Vector2 (pos.x,pos.y + speed * Time.deltaTime);
		transform.position = pos; 
	
	}



	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Monster") {
			Destroy (other.gameObject);
			Destroy (gameObject);
	
		}

	}

	}

