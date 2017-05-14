using UnityEngine;
using System.Collections;

public class bucket : MonoBehaviour {

	public GameObject Bucket;
	float timer = 0;
	int flo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (timer == 0) 
		{
			
			flo = Random.Range (0, 2);
		}

		timer += Time.deltaTime;
/////////////////////////////////////////////////////////////////////////////////////////////

		if (flo == 0 && timer >= 2.0f) 
		{

				Instantiate (Bucket);
				timer = 0;

		}
		else if(flo == 1 && timer >= 1.0f)
		{
				
				Instantiate (Bucket);
				timer = 0;

		}


	}
}
