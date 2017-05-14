using UnityEngine;
using System.Collections;

public class destory : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D box)
	{



		if (box.tag == ("Ball")) 
		{

			Debug.Log ("bye");
			Destroy (box.gameObject);

		}

	}
}
