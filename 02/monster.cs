using UnityEngine;
using System.Collections;

public class monster : MonoBehaviour {

	int Monster;
	float timer = 0;
	public float speed;
	public Animator boss;
	public bool go;
	public float scale;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		timer += Time.deltaTime;

		boss.SetBool ("walk", go);

		if (timer >= 1.0f) 
		{

			Monster = Random.Range(0, 3);

			Debug.Log (Monster);

			timer = 0;
	
		}

		if (Monster == 0) 
		{

			gameObject.transform.Translate (speed * Time.deltaTime, 0, 0);
			go = true;
			transform.localScale = new Vector3(scale,scale,scale);

		}
		else if (Monster == 1) 
		{

			gameObject.transform.Translate (-1*speed * Time.deltaTime, 0, 0);
			go = true;
			transform.localScale = new Vector3(-1*scale,scale,scale);

		}
		else if (Monster == 2) 
		{

			gameObject.transform.Translate (0, 0, 0);
			go = false;

		}

	}

	void OnTriggerStay2D(Collider2D way)
	{

		if (way.CompareTag ("Right") ) 
		{

			Monster = 0;

		}

		if (way.CompareTag ("Left") ) 
		{

			Monster = 1;

		}

	}
		
}
