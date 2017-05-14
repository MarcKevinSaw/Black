using UnityEngine;
using System.Collections;

public class boyjump : MonoBehaviour {


	public bool ground;
	public Animator Jump;
	public int speed;


	// Use this for initialization
	void Start () {

	
	}

	void OnTriggerStay2D(Collider2D player){


	
		if (player.CompareTag ("Ground") || player.CompareTag ("Climb")) {
		
			ground = true;


		
		} 
	}
	void OnTriggerExit2D(Collider2D player){




			ground = false;



		}

	// Update is called once per frame
	void Update () {
	
		Jump.SetBool ("ground", ground);




		if (Input.GetKeyDown (KeyCode.Space) && ground == true) 
		{
			

			GetComponent<Rigidbody2D>().AddForce(new Vector2(0,speed));


		}


	}

}