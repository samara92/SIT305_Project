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

	public bool speedPowerUp = false;
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



		#if UNITY_2017_1_OR_NEWER 
		if (Input.GetKeyDown (KeyCode.Space) && grounded) {
		
			Jump ();
		}

		if (Input.GetKeyDown (KeyCode.Space) && !grounded && !doubleJump) {

			Jump ();
			doubleJump = true;
		}
		//moveVelocity = 0f;
		if (Input.GetKey (KeyCode.A)) {

			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (-movmentSpeed, playerRigidBody2DVelocity.y);
			Move(-1);
		}

		if (Input.GetKey (KeyCode.D)) {

			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (movmentSpeed, playerRigidBody2DVelocity.y);
			Move(1);
		}
		if(Input.GetKeyUp(KeyCode.D)|| Input.GetKeyUp(KeyCode.A)){
			Move(0);
		}

		if (Input.GetKeyDown (KeyCode.L)) {
			//Instantiate (fireBall,firePoint.position,firePoint.rotation);
			Fire();
			shotDelayCounter = shotDelay;
		}
		if (Input.GetKey (KeyCode.L)) {
			shotDelayCounter -= Time.deltaTime;

			if (shotDelayCounter <= 0) {

				shotDelayCounter = shotDelay;
				Fire ();
				//Instantiate (fireBall,firePoint.position,firePoint.rotation);
			}

		}
		#endif
		if (!speedPowerUp) {
			playerAnim.SetBool ("PoweUp", false);
		}
		if (speedPowerUp) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity*2, GetComponent<Rigidbody2D> ().velocity.y);
			GetComponent<Rigidbody2D> ().gravityScale = 0;
			GetComponent<PolygonCollider2D> ().enabled = false;
			playerAnim.SetBool ("PoweUp", speedPowerUp);
			if (playerRigidBody2DVelocity.x > 0)
				transform.localScale = new Vector3 (1f,1f,1f);
			else if(playerRigidBody2DVelocity.x <0)
				transform.localScale = new Vector3 (-1f,1f,1f);
		} else {
			GetComponent<PolygonCollider2D> ().enabled = true;
			GetComponent<Rigidbody2D> ().gravityScale = 5;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);

		playerAnim.SetFloat ("Speed", Mathf.Abs (playerRigidBody2DVelocity.x));
		if (playerRigidBody2DVelocity.x > 0)
			transform.localScale = new Vector3 (1f,1f,1f);
		else if(playerRigidBody2DVelocity.x <0)
			transform.localScale = new Vector3 (-1f,1f,1f);

		}

	}

	public void Move(float moveInput){
	
		moveVelocity = movmentSpeed * moveInput;
	}

	public void Fire(){
		Instantiate (fireBall,firePoint.position,firePoint.rotation);
	}

	public void PowerUp(){
	
	//TO DO: power Up
	}

	public void Jump(){
		
		//GetComponent<Rigidbody2D> ().velocity = new Vector2 (playerRigidBody2DVelocity.x, jumpHeight);
		if(speedPowerUp){
			return;
		}
		if (grounded) {

			//Jump ();
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (playerRigidBody2DVelocity.x, jumpHeight);
		}

		if (!grounded && !doubleJump) {

			//Jump ();
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (playerRigidBody2DVelocity.x, jumpHeight);
			doubleJump = true;
		}
	}
}
