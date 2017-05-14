using UnityEngine;
using System.Collections;

public class X : MonoBehaviour {

	public GameObject boss;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D Exit)
	{

		if (Exit.CompareTag ("Player")) 
		{

			boss.SetActive (false);

		}

	}
}
