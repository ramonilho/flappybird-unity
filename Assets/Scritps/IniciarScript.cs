using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IniciarScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FlappyBirdScript.inGame = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return) || Input.touchCount == 2) {
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene ("game");
		}

	}
}
