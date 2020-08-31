using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour 
{
	[SerializeField]
	private GameObject ball;

	void Awake()
	{
		
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "hoop_top")
		{
			Rigidbody2D other=ball.GetComponent<Rigidbody2D> ();
			other.gravityScale = 0f;


		}


	}
}
