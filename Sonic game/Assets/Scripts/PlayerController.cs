using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player movement
	public float jumpHeight;
	private float moveVelocity;
	public float movmentSpeed;
	public Vector2 playerRigidBody2DVelocity;
	//Double jump
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private bool doubleJump;

	//Player animation
	private Animator playerAnim;

	public Transform firePoint;
	public GameObject fireBall;

	public float shotDelay;
	private float shotDelayCounter;
	void Start(){
		playerAnim = GetComponent<Animator> ();
	}

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

		moveVelocity = 0f;

		if (Input.GetKey (KeyCode.A)) {

			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (-movmentSpeed, playerRigidBody2DVelocity.y);
			moveVelocity = - movmentSpeed;
		}

		if (Input.GetKey (KeyCode.D)) {

			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (movmentSpeed, playerRigidBody2DVelocity.y);
			moveVelocity = movmentSpeed;
		}

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

		playerAnim.SetFloat ("Speed", Mathf.Abs (playerRigidBody2DVelocity.x));
		if (playerRigidBody2DVelocity.x > 0)
			transform.localScale = new Vector3 (1f,1f,1f);
		else if(playerRigidBody2DVelocity.x <0)
			transform.localScale = new Vector3 (-1f,1f,1f);

		if (Input.GetKeyDown (KeyCode.L)) {
			Instantiate (fireBall,firePoint.position,firePoint.rotation);
			shotDelayCounter = shotDelay;
		}
		if (Input.GetKey (KeyCode.L)) {
			shotDelayCounter -= Time.deltaTime;

			if (shotDelayCounter <= 0) {
			
				shotDelayCounter = shotDelay;
				Instantiate (fireBall,firePoint.position,firePoint.rotation);
			}

		}

	}

	public void Jump(){
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (playerRigidBody2DVelocity.x, jumpHeight);
	}
}
