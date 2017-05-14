using UnityEngine;
using System.Collections;

public class gameover03 : MonoBehaviour 
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
			
			Instantiate (camera);
			GameObject.Find("All").SetActive (false);
			Instantiate (die);

		}

	}
}