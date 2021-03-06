﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CharacterManager : MonoBehaviour {
	public float fireRate = 1;
	public float nextFire = 1;
	public GameObject shot;
	public Transform firePos;


	/**/
	public float speed = 3.5f;
	public float jumpPower = 350;


	public bool grounded =false;
	public Transform groundCheck;
	float groundRadius = 0.05f;
	public LayerMask whatIsGround;


	private Rigidbody2D rb2d;
	private Animator anim;


	void Start () {

		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
		//shotSpawn = transform.FindChild("shotSpawn");

		//firePos = transform.FindChild ("firePos");
		firePos = GameObject.FindGameObjectWithTag("firePos").transform;

	}
	
	// Update is called once per frame


	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Fire ();

		}
		}

	void FixedUpdate(){
		//for movement
		float h = Input.GetAxis ("Horizontal");
		rb2d.velocity = new Vector2(h * speed, rb2d.velocity.y);


		//for jump
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);
		anim.SetFloat ("vSpeed", rb2d.velocity.y);
		if (grounded && rb2d.velocity.y <= 0) {
			anim.SetBool ("Ground", false);
			rb2d.velocity = new Vector2 (0, 0);
			rb2d.AddForce (new Vector2 (0, jumpPower));

		}

	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "Monster") {
			
			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);



		

		}
	}

	void Fire(){

		Instantiate (shot, firePos.position,firePos.rotation);
	}
}
		 
			
		
