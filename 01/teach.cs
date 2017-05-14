using UnityEngine;
using System.Collections;

public class teach : MonoBehaviour {
	
	public GameObject Teach;
	float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		timer += Time.deltaTime;

		if (timer >= 3.0f) 
		{

			Teach.SetActive (false);

		}
	
	}
}
