using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop_Collect : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "hoop_shadow" || target.tag == "hoop_top")
		{
			target.gameObject.SetActive (true);

		}

	}
}
