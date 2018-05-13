using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player movement
	public float jumpHeight;
	public float movmentSpeed;

	//Double jump
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private bool doubleJump;

	void FixedUpdate(){
	
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {

		if (grounded)
			doubleJump = false;

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
		
			Jump ();
		}

		if (Input.GetKeyDown (KeyCode.Space) && !grounded && !doubleJump) {

			Jump ();
			doubleJump = true;
		}

		if (Input.GetKey (KeyCode.A)) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-movmentSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKey (KeyCode.D)) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (movmentSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}

	public void Jump(){
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
	}
}
