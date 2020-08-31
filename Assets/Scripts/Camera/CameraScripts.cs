using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScripts : MonoBehaviour {

	private float speed = 2f;
	private float acceleration = 1f;
	private float maxSpeed = 4f;

	[HideInInspector]
	public bool moveCamera;
	// Use this for initialization
	void Start () {
		moveCamera = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (moveCamera)
		{
			MoveCam();

		}	

	}

	void MoveCam()
	{
		Vector3 temp = transform.position;

		float oldY = temp.y;
		float newY = temp.y - (speed * Time.deltaTime);

		temp.y = Mathf.Clamp (temp.y, oldY, newY);

		transform.position = temp;

		speed += acceleration * Time.deltaTime;

		if (speed >maxSpeed)
		{

			speed = maxSpeed;
		}
	}

}
