using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {


	float timer = 0;
	public GameObject main;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		timer += Time.deltaTime;

		if (timer >= 5.0f) 
		{

			main.SetActive (true);

		}

		if (timer >= 6.5f) 
		{

			GetComponent<Animator> ().enabled = true;

		}
	
	}
}
