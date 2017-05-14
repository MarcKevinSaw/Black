using UnityEngine;
using System.Collections;

public class transparent : MonoBehaviour {

	public Animator change;
	public bool model = false ;
	float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		change.SetBool ("Change", model);

		if (Input.GetKeyDown (KeyCode.F))
		{

			model = true;

		}

		if (model == true) 
		{

			timer += Time.deltaTime;
			if (timer >= 2.0f) 
			{

				model = false;
				timer = 0;

			}

		}
	
	}
}
