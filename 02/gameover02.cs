using UnityEngine;
using System.Collections;

public class gameover02 : MonoBehaviour 
{

	public GameObject die; 
	public GameObject camera; 

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{



	}

	void OnTriggerEnter2D(Collider2D player)
	{

		if (player.CompareTag ("Player")) 
		{

			GameObject.Find("All").SetActive (false);
			Instantiate (die);
			camera.SetActive (true);

		}

	}
}