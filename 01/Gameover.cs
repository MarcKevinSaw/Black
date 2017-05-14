using UnityEngine;
using System.Collections;

public class Gameover : MonoBehaviour 
{

	public GameObject gameover; 
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

			gameover.SetActive (false);
			Instantiate (die);
			camera.SetActive (true);

		}

	}
}
