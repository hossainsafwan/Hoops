using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class points : MonoBehaviour 
{

	public static int scoreCount = -1;

	[SerializeField]
	private Text score,GameOver,highScore,highScore_title;

	[SerializeField]
	private GameObject ball;

	[SerializeField]
	private Button resume,back;

	void Start()
	{
		back.image.enabled = false;
		resume.image.enabled= false;
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "hoop1_bottom" && target.tag != "hoop_top") 
		{
			scoreCount = scoreCount + 1;
			score.text = scoreCount.ToString();
		}
		else if (target.tag == "hoop3_bottom" && target.tag != "hoop_top") 
		{

			scoreCount = scoreCount + 2;
			score.text =  scoreCount.ToString();
		} 
		else if (target.tag == "hoop2_bottom" && target.tag != "hoop_top")
		{
			scoreCount = scoreCount + 5;
			score.text =  scoreCount.ToString();
		} 
		else if (target.tag == "hoop4_bottom" && target.tag != "hoop_top")
		{
			scoreCount = scoreCount + 10;
			score.text =  scoreCount.ToString();

		}
		else if (target.tag == "hoop_top")
		{
			Rigidbody2D other= ball.GetComponent<Rigidbody2D> ();
			other.velocity = Vector2.zero;
			other.angularVelocity = 0f;
			other.gravityScale = 0f;

			Rigidbody2D other1= this.GetComponent<Rigidbody2D> ();
			other1.velocity = Vector2.zero;
			other1.angularVelocity = 0f;
			other1.gravityScale = 0f;

			ball.GetComponent<ball> ().enabled = false;
			this.GetComponent<ball> ().enabled = false;
			ball.GetComponent<BallMovementTouch> ().enabled = false;
			this.GetComponent<BallMovementTouch> ().enabled = false;

			if (scoreCount > PlayerPrefs.GetInt("highScore"))
			{
				PlayerPrefs.SetInt ("highScore", scoreCount);

			}
			scoreCount = -1;

			GameOver.enabled = true;
			highScore_title.enabled = true;
			highScore.enabled = true;
			highScore.text = PlayerPrefs.GetInt ("highScore").ToString ();

			back.image.enabled = true;
			resume.image.enabled= true;



		}


	}



}
