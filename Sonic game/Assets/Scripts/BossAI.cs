using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;

	public Transform obstacleCheck;
	public float obstacleCheckRadius;
	public LayerMask whatIsobstacle;
	private bool hittingObstacle;

	private bool notAtEdge;
	public Transform edgeCheck;

	private float ySize;
	// Use this for initialization
	void Start () {
		ySize = transform.localScale.y;
	}

	//We use for physics simulations.FixedUpdate() runs at a constant 50 frames per second to match the physics engine.
	void FixedUpdate(){

		hittingObstacle = Physics2D.OverlapCircle (obstacleCheck.position, obstacleCheckRadius, whatIsobstacle);
		notAtEdge = Physics2D.OverlapCircle (edgeCheck.position, obstacleCheckRadius, whatIsobstacle);
		if (hittingObstacle || !notAtEdge )
			moveRight = !moveRight;

		if (moveRight) {
			transform.localScale = new Vector3 (-ySize,transform.localScale.y,transform.localScale.z);
			//getting the rigid body and apply it a velocity.
			try {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());
			}

		} else {
			transform.localScale = new Vector3 (ySize,transform.localScale.y,transform.localScale.z);
			try {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			} catch (System.Exception ex) {
				StaticData.ErrorLogList.Add (ex.ToString ());
			}
		}
	}
}
