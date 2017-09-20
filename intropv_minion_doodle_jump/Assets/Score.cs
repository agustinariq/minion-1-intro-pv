using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int scoreValue;
	public Text scoreText;
	public GameObject player;
	// Use this for initialization
	void Start () {
		//scoreText.GetComponent<GUIText>().text = "Score:";
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (player.gameObject.GetComponent<Rigidbody2D>().position.y);
		scoreText.text = player.gameObject.GetComponent<Rigidbody2D>().position.y.ToString();
	}
}
