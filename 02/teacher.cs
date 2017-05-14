using UnityEngine;
using System.Collections;

public class teacher : MonoBehaviour {

	public bool T = false;
	public Animator ain;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		ain.SetBool ("change", T);
	
	}

	void OnTriggerEnter2D(Collider2D Teacher)
	{
		
		if (Teacher.CompareTag ("Player")) 
		{

			T = true;

		}

	}
}
