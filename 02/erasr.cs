using UnityEngine;
using System.Collections;

public class erasr : MonoBehaviour {

	public Rigidbody2D eraser;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerStay2D(Collider2D era){



		if (era.CompareTag ("Player") ) 
		{

			eraser.isKinematic = false;

		} 

	}
}
