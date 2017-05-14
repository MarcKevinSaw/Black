using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D elevator){



		if (elevator.CompareTag ("Player") ) {


			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))
			{

				GameObject.Find ("I").transform.Translate (0, 2, 0);

			}

		} 

	}

}
