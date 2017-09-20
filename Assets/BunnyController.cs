﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyController : MonoBehaviour {

	public float maxSpeed = 10f;
	public float speed = 20f;
	public float jumpPower = 0f;

	private bool grounded;
	private Rigidbody2D rb2d;
	private bool jump;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded) {
			jump = true;
		}

	//	Debug.Log (rb2d.velocity);
		
	}

	void FixedUpdate(){

		Vector3 fixedVelocity = rb2d.velocity;
		fixedVelocity.x *= 0.90f;

		if (grounded) {
			rb2d.velocity = fixedVelocity;
		}
	
		float h = Input.GetAxis ("Horizontal");
		rb2d.AddForce (Vector2.right * speed * h);

		float limitedSpeed = Mathf.Clamp (rb2d.velocity.x, -maxSpeed, maxSpeed);
		rb2d.velocity = new Vector2 (limitedSpeed, rb2d.velocity.y);

		if (h > 0.1f) {
			transform.localScale = new Vector3 (1f, 1f, 1f);
		}
		if (h < -0.1f) {
			transform.localScale = new Vector3 (-1f, 1f, 1f);
		}

		if (jump) {
	//	if (grounded) {
			rb2d.AddForce (Vector2.up * jumpPower, ForceMode2D.Impulse);
			jump = false;
		}

		if (rb2d.velocity.y < -20) {
			GameOver.show();
		}

		//Debug.Log (rb2d.position);
		var pos = Camera.main.WorldToViewportPoint(transform.position);
		pos.x = Mathf.Clamp(pos.x, 0.05f, 0.95f);
		pos.y = Mathf.Clamp(pos.y, -1f, 0.95f);
		transform.position = Camera.main.ViewportToWorldPoint (pos);

		//Debug.Log (rb2d.velocity);

	}

	void OnCollisionStay2D(Collision2D colission) {
		//int len = colission.contacts.GetLongLength;
		//Debug.Log (colission.contacts[0].point);
		grounded = true;
	}

	void OnCollisionExit2D(Collision2D colission) {
		grounded = false;
	}


}
