using UnityEngine;
using System.Collections;


public class boy: MonoBehaviour {

	

	public int speed;
	public int climbspeed = 1;
	public float Move ;
	public Animator walk;
	public bool go;
	public float climb;
	public Rigidbody2D rb;
	public bool hi;
	public bool hello;
	public float scale;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}



	void Update () {
		

		Move = speed * Input.GetAxis ("Horizontal") * Time.deltaTime;
		if (Move > 0 || Move < 0) {

			go = true;

		} else {

			go = false;

		}

		if(Move > 0) {

			transform.localScale = new Vector3(scale,scale,scale);


		} else if(Move < 0) {

			transform.localScale = new Vector3(-1*scale,scale,scale);


		} 
	
		walk.SetBool ("Speed", go);
		walk.SetBool ("hi", hello);
		transform.Translate (Move, 0, 0);


		climb = Input.GetAxis ("Vertical");

		if (hi == true) {
		
			transform.Translate (0, climbspeed * climb * Time.deltaTime, 0);
			rb.isKinematic = true;
		
		} else {
		
			rb.isKinematic = false;
		
		}

	}


	void OnTriggerStay2D(Collider2D player)
	{


		if (player.CompareTag ("Climb")) {

			if (climb != 0) {

				hi = true;
				hello = true;

			}else if (Input.GetKeyDown (KeyCode.Space)) {
			
				hi = false;
			
			}

		}

	}

	void OnTriggerExit2D(Collider2D player)
	{



			hi = false;
			hello = false;

	}


}