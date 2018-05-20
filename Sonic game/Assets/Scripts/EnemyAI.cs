using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;

	public Transform obstacleCheck;
	public float obstacleCheckRadius;
	public LayerMask whatIsobstacle;
	private bool hittingObstacle;

	private bool notAtEdge;
	public Transform edgeCheck;
	// Use this for initialization
	void Start () {
		
	}

	//We use for physics simulations.FixedUpdate() runs at a constant 50 frames per second to match the physics engine.
	void FixedUpdate(){
		//check if obstacle is around the given radius.Obstacle is the layer of the game object
		hittingObstacle = Physics2D.OverlapCircle (obstacleCheck.position, obstacleCheckRadius, whatIsobstacle);
		//check if there is a ground edge around the given radius
		notAtEdge = Physics2D.OverlapCircle (edgeCheck.position, obstacleCheckRadius, whatIsobstacle);
		if (hittingObstacle || !notAtEdge ) // if hittingObstacle true and edge is not there change enemy diraction
			moveRight = !moveRight; 

		if (moveRight) {
			// change the local scale x to -1 for flip the enemy image when it moves right
			transform.localScale = new Vector3 (-1f,1f,1f); 
			//get the attached rigidbody and give it's a positive velocity in order to move the object right
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			transform.localScale = new Vector3 (1f,1f,1f);
			//get the attached rigidbody and give it's a negative velocity in order to move the object left
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
