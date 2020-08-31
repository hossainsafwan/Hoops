using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Bounds_Collider : MonoBehaviour {

	private float maxX, minX;
	// Use this for initialization
	void Start ()
	{
		SetmaxXminX ();
	}

	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x > maxX)
		{
			Vector3 temp = transform.position;//so that y and z positions remain same
			temp.x = maxX;//change x position
			transform.position = temp;

		}	
		else if (transform.position.x < minX)
		{
			Vector3 temp = transform.position;
			temp.x = minX;
			transform.position = temp;

		}
	}

	void SetmaxXminX()
	{
		Vector3 bound = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width,0,0));

		maxX = bound.x;
		minX = -bound.x;

	}
}
