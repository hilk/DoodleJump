using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlat : MonoBehaviour {
	public float jumpHeight = 400f;
	float velY;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		velY = rb2d.velocity.y;
	}
	void OnTriggerEnter2D(Collider2D coll){
		if (coll.tag == "JumpPlat" && velY <= 0) {
			rb2d.velocity = new Vector2 (0,0);
			rb2d.AddForce (new Vector2 (0, jumpHeight));

		}
			
	}

}
