using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarGame : MonoBehaviour {
	
	public void StartGame()
	{

		SceneManager.LoadScene ("1");
	}
	public static void Menu()
	{

		SceneManager.LoadScene ("Menu");
	}

}
