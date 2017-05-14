using UnityEngine;
using System.Collections;

public class candyball : MonoBehaviour
{

	//public GameObject player;

	// Use this for initialization
	void Start () 
	{
	


	}
	
	// Update is called once per frame
	void Update () 
	{
	


	}

	void OnTriggerStay2D(Collider2D ball)
	{

		if (ball.CompareTag ("Player")) 
		{

			Debug.Log("hi");
			GameObject.Find("I").GetComponent<boy> ().enabled = false;
			GameObject.Find("I").GetComponent<boyjump> ().enabled = false;

		}
			

	}

}
