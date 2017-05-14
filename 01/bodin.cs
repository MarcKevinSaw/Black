using UnityEngine;
using System.Collections;

public class bodin : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D Bodin){



		if (Bodin.CompareTag ("Player")) {


			GameObject.Find("I").GetComponent<Rigidbody2D>().AddForce(new Vector2(0,speed));


		} 
	}
}
