using UnityEngine;
using System.Collections;

public class classmate : MonoBehaviour {

	int Monster;
	float timer = 0;
	public float speed;
	public float scale;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		timer += Time.deltaTime;


		if (timer >= 1.0f) 
		{

			Monster = Random.Range(0, 2);

			timer = 0;

		}

		if (Monster == 0) 
		{

			gameObject.transform.Translate (speed * Time.deltaTime, 0, 0);
			transform.localScale = new Vector3(-1*scale,scale,scale);

		}
		else if (Monster == 1) 
		{

			gameObject.transform.Translate (-1*speed * Time.deltaTime, 0, 0);
			transform.localScale = new Vector3(scale,scale,scale);

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
