using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player movement
	public float jumpHeight;
	public float movmentSpeed;
	public Vector2 playerRigidBody2DVelocity;
	//Double jump
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private bool doubleJump;

	void Start(){
		playerAnim = GetComponent<Animator> ();
	}

	//Player animation
	private Animator playerAnim;
	void FixedUpdate(){
	
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	// Update is called once per frame
	void Update () {
		playerRigidBody2DVelocity = new Vector2( GetComponent<Rigidbody2D> ().velocity.x,GetComponent<Rigidbody2D> ().velocity.y);
		if (grounded)
			doubleJump = false;

		playerAnim.SetBool ("Grounded", grounded);

		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
		
			Jump ();
		}

		if (Input.GetKeyDown (KeyCode.Space) && !grounded && !doubleJump) {

			Jump ();
			doubleJump = true;
		}

		if (Input.GetKey (KeyCode.A)) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-movmentSpeed, playerRigidBody2DVelocity.y);
		}

		if (Input.GetKey (KeyCode.D)) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (movmentSpeed, playerRigidBody2DVelocity.y);
		}

		playerAnim.SetFloat ("Speed", Mathf.Abs (playerRigidBody2DVelocity.x));
		if (playerRigidBody2DVelocity.x > 0)
			transform.localScale = new Vector3 (1f,1f,1f);
		else if(playerRigidBody2DVelocity.x <0)
			transform.localScale = new Vector3 (-1f,1f,1f);
	}

	public void Jump(){
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (playerRigidBody2DVelocity.x, jumpHeight);
	}
}
