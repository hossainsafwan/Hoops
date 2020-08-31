using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementTouch : MonoBehaviour {

	public float speed = 2f, maxVelocity = 4f;
	[SerializeField]
	private Rigidbody2D myBody;

	private bool moveLeft, moveRight;
	// Use this for initialization
	void Awake()
	{
		myBody = GetComponent<Rigidbody2D>();//Get Component RigidBody 2D

	}
	
	// Update is called once per frame
	void FixedUpdate ( ) 
	{
		if (moveLeft)
		{
			MoveLeft ();

		} 
		if (moveRight)
		{
		
			MoveRight ();
		}
	}
	public void SetmLeft(bool left)//Setter
	{
		this.moveLeft = left;
		this.moveRight = !left;
	
	}

	public void Setstop()//Setter
	{
		moveLeft = moveRight = false;

	}
	void MoveLeft ( ) 
	{
		float forceX = 0f;

		float vel = Mathf.Abs (myBody.velocity.x);

		if (vel < maxVelocity) 
		{
			forceX = -speed;//negative speed going to the left side
		}

		myBody.AddForce (new Vector2(forceX,0));


	}
	void MoveRight ()
	{
		float forceX = 0f;

		float vel = Mathf.Abs (myBody.velocity.x);


		if (vel < maxVelocity) 
		{
			forceX = speed;
		}

		myBody.AddForce (new Vector2(forceX,0));


	}
}
