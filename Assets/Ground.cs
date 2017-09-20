using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void FixedUpdate () {
		var cameraPosition = Camera.main.transform.position;
		var vectorToCloud = (transform.position - cameraPosition);
		//Debug.Log (vectorToCloud.y);
		if ( vectorToCloud.y < -8f ) {
			Destroy (gameObject);
		}
	}
	public void OnBecameInvisible()
	{	

	}

}