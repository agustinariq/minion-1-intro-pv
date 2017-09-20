using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public GameObject gameOverText;
	public static GameObject GameOverStatic;

	// Use this for initialization
	void Start () {

		GameOver.GameOverStatic = gameOverText;
		GameOver.GameOverStatic.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void show(){
		GameOver.GameOverStatic.gameObject.SetActive (true);
	}
}
