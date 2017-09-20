using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonCloud : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var cameraPosition = Camera.main.transform.position;
		var vectorToCloud = (transform.position - cameraPosition);
		//Debug.Log (vectorToCloud);
		if (vectorToCloud.y < -8) {
			Destroy (gameObject);
		}
	}
	public void OnBecameInvisible()
	{	//DestroyObject (gameObject);
		
	}

}
