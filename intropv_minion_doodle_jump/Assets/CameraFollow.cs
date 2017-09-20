using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject follow;
	public Vector3 minCameraPosition;
	public Vector3 maxCameraPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float positionX = follow.transform.position.x;
		float positionY = follow.transform.position.y;

		transform.position = new Vector3 (
			Mathf.Clamp(positionX, minCameraPosition.x, maxCameraPosition.x), 
			Mathf.Clamp(positionY, minCameraPosition.y, maxCameraPosition.y), 
			transform.position.z);
	}

	void update(){
	}
}
