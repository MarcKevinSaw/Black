using UnityEngine;
using System.Collections;

public class miss : MonoBehaviour {

	public bool power = false;
	float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if(Input.GetKeyDown (KeyCode.F) && power == false)
		{

			power = true;
			
		}

		if(power == true && timer <= 2.0f)
		{

			timer += Time.deltaTime;
			GetComponent<BoxCollider2D>().enabled = false;
			GetComponent<CircleCollider2D>().enabled = false;
			GetComponent<Rigidbody2D>().isKinematic = true;

		}
		
		if(timer >= 2.0f)
		{

			GetComponent<BoxCollider2D>().enabled = true;
			GetComponent<CircleCollider2D>().enabled = true;
			GetComponent<Rigidbody2D>().isKinematic = false;
			timer = 0;
			power = false;

		}


	}
}
