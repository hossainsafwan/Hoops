using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class touch : MonoBehaviour, IPointerUpHandler,IPointerDownHandler
{

	private BallMovementTouch ballMovemnt;
	private BallMovementTouch ballMovemnt_Collider;


	void Start()
	{
		ballMovemnt = GameObject.Find ("ball").GetComponent<BallMovementTouch>();
		ballMovemnt_Collider = GameObject.Find ("Collider").GetComponent<BallMovementTouch>();
	}
	public void OnPointerDown(PointerEventData data)//when we touch a button
	{
		if(gameObject.name== "Left")
		{
			Debug.Log ("Touching The left button");
			ballMovemnt.SetmLeft (true);
			ballMovemnt_Collider.SetmLeft (true);
		}
		else
		{
			ballMovemnt.SetmLeft (false);
			ballMovemnt_Collider.SetmLeft (false);
			Debug.Log ("Touching The Right button");


		}

	}

	public void OnPointerUp(PointerEventData data)//when we release a button
	{
		
		ballMovemnt.Setstop();
		ballMovemnt_Collider.Setstop();
	}
}
