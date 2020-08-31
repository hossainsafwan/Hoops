using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		SpriteRenderer sr = GetComponent <SpriteRenderer> ();
		Vector3 tempScale = transform.localScale;

		float width = sr.sprite.bounds.size.x;//gives width of sprite

		float worldHeight = Camera.main.orthographicSize * 2f;//top to bottom of camera *2 because you want the whole screen height
		float worldWidth = worldHeight /Screen.width * Screen.height;

		tempScale.x = worldWidth / width;//width of camera/ width of sprite

		transform.localScale = tempScale;
	}
	

}
