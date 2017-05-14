using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {



	public GameObject die; 
	public GameObject camera; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D DOOR)
	{

		if (DOOR.CompareTag ("Player")) 
		{

			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))
			{

				GameObject.Find("All").SetActive (false);
				Instantiate (die);
				camera.SetActive (true);

			}

		}

	}
}
