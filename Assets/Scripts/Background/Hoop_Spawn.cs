using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoop_Spawn : MonoBehaviour {

	// Use this for initialization

	private float lastY;
	private float distanceBetweenHoopsY = 4f;
	private float minX;
	private float maxX;

	private GameObject[] hoops_shadow;
	private GameObject[] hoops_top;

	public GameObject hoop1_top;
	public GameObject hoop1_bottom;
	public GameObject hoop1_shadow;

	public GameObject hoop2_top;
	public GameObject hoop2_bottom;
	public GameObject hoop2_shadow;

	public GameObject hoop3_top;
	public GameObject hoop3_bottom;
	public GameObject hoop3_shadow;

	public GameObject hoop4_top;
	public GameObject hoop4_bottom;
	public GameObject hoop4_shadow;

	void Start () 
	{
		xBounds();
		FindLastHoopPos();
	}
	
	void FindLastHoopPos()//last Hoop_Top Y
	{
		hoops_shadow = GameObject.FindGameObjectsWithTag ("hoop_shadow");
		hoops_top = GameObject.FindGameObjectsWithTag ("hoop_top");

		lastY = hoops_shadow[0].transform.position.y;

		for(int i=1; i<hoops_shadow.Length;i++)
		{
			if (lastY > hoops_shadow[i].transform.position.y)
			{
				lastY = hoops_shadow[i].transform.position.y;

			}

		}


	}



	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "hoop_shadow" && target.transform.position.y <= lastY)
		{
			int hoopNum = UnityEngine.Random.Range(1,5);//max not inclusive

			if (hoopNum == 1)
			{
				Vector2 position = new Vector2(UnityEngine.Random.Range(minX,maxX),lastY - distanceBetweenHoopsY);
				lastY = position.y;

				Instantiate (hoop1_top,position,Quaternion.identity);

				position.y = position.y - 0.18f;

				Instantiate (hoop1_bottom,position,Quaternion.identity);

				position.x = position.x + 0.012f;
				position.y = position.y - 0.06f;

				Instantiate (hoop1_shadow,position,Quaternion.identity);

			}
			else if (hoopNum == 2)
			{
				Vector2 position = new Vector2(UnityEngine.Random.Range(minX,maxX),lastY - distanceBetweenHoopsY);
				lastY = position.y;

				Instantiate (hoop2_top,position,Quaternion.identity);

				position.y = position.y - 0.18f;

				Instantiate (hoop2_bottom,position,Quaternion.identity);

				position.x = position.x + 0.01f;
				position.y = position.y - 0.06f;

				Instantiate (hoop2_shadow,position,Quaternion.identity);

			}
			else if (hoopNum == 3)
			{

				Vector2 position = new Vector2(UnityEngine.Random.Range(minX,maxX),lastY - distanceBetweenHoopsY);
				lastY = position.y;

				Instantiate (hoop3_top,position,Quaternion.identity);

				position.y = position.y - 0.16f;

				Instantiate (hoop3_bottom,position,Quaternion.identity);

				position.x = position.x + 0.01f;
				position.y = position.y - 0.05f;

				Instantiate (hoop3_shadow,position,Quaternion.identity);

			}
			else
			{
				Vector2 position = new Vector2(UnityEngine.Random.Range(minX,maxX),lastY - distanceBetweenHoopsY);
				lastY = position.y;

				Instantiate (hoop4_top,position,Quaternion.identity);

				position.y = position.y - 0.19f;

				Instantiate (hoop4_bottom,position,Quaternion.identity);


				position.y = position.y - 0.04f;

				Instantiate (hoop4_shadow,position,Quaternion.identity);

			}

		}


	}

	void xBounds()//Get min and MaxX Position
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3(Screen.width,Screen.height,0));

		minX = -bounds.x + 1f;
		maxX = bounds.x - 1f;

	}
}
