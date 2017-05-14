using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	// Use this for initialization

	public void changescene(int SceneChangeTo)
	{

		AutoFade.LoadLevel (SceneChangeTo, 2, 1, Color.white);

	}


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
