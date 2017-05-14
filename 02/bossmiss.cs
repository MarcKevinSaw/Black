using UnityEngine;
using System.Collections;

public class bossmiss : MonoBehaviour {

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
			GetComponent<CircleCollider2D>().enabled = false;

		}

		if(timer >= 2.0f)
		{
			
			GetComponent<CircleCollider2D>().enabled = true;
			timer = 0;
			power = false;

		}


	}
}