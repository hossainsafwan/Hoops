using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highScore : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private Text hs;

	void Awake()
	{
		hs.text = PlayerPrefs.GetInt ("highScore").ToString();

	}
		
}
