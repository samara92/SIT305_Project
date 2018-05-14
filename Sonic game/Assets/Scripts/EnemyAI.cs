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
	void FixedUpdate(){

		hittingObstacle = Physics2D.OverlapCircle (obstacleCheck.position, obstacleCheckRadius, whatIsobstacle);
		notAtEdge = Physics2D.OverlapCircle (edgeCheck.position, obstacleCheckRadius, whatIsobstacle);
		if (hittingObstacle || !notAtEdge )
			moveRight = !moveRight;

		if (moveRight) {
			transform.localScale = new Vector3 (-1f,1f,1f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			transform.localScale = new Vector3 (1f,1f,1f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
