using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour //inheriting from MonoBehaviour
{

	public float speed = 2f, maxVelocity = 4f;

	[SerializeField]
	private Rigidbody2D myBody;

	// Use this for initialization
	void Awake()
	{
		myBody = GetComponent<Rigidbody2D>();//Get Component RigidBody 2D

	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()//THIS FUNCTION IS CALLED EVERY couple of FRAMES PER SECOND 
	{
		BallMovement();
	}

	void BallMovement()
	{

		float forceX = 0f;

		float vel = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");//return a number when left right or A, D key pressed -1 if press A or left key 1 if right or D and 0 if no key pressed

		if (h >0 )//going right
		{

			if (vel < maxVelocity) 
			{
				forceX = speed;
			}


		}
		else if (h<0)//going left
		{
			if (vel < maxVelocity) 
			{
				forceX = -speed;//negative speed going to the left side
			}

		}

		myBody.AddForce (new Vector2(forceX,0));

	}
}
