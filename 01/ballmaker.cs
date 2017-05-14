using UnityEngine;
using System.Collections;

public class ballmaker : MonoBehaviour 
{

	public GameObject Ball1;
	float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		timer += Time.deltaTime;

		if (timer >= 2.0f) 
		{

			Instantiate (Ball1);
			timer = 0;

		}

		//Debug.Log (timer);
	}
}
