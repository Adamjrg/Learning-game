using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTriger1 : MonoBehaviour {


	public GameObject text;

	void OnTriggerEnter(Collider col)
	{
		
			text.SetActive(true);
	}
			
			
			
}

