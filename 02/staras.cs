using UnityEngine;
using System.Collections;

public class staras : MonoBehaviour {

	public GameObject stair;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D Stair)
	{

		if (Stair.CompareTag ("Player") ) {


			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))
			{

				GameObject.Find ("I").transform.position = stair.transform.position;

			}

		} 

	}
}
