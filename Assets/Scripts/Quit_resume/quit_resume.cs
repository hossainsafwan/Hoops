using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class quit_resume : MonoBehaviour {

	[SerializeField]
	private Button resume,back;

	public void Resume()
	{
		SceneManager.LoadScene ("1");
		back.image.enabled = false;
		resume.image.enabled = false;


	}
	public void Quit()
	{

		SceneManager.LoadScene ("Menu");
		back.enabled = false;
		resume.enabled = false;
	}
}
