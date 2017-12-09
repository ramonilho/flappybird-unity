using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour {

	public float velocity;
	public float initialHeight, finalHeight;
	public float limitX;

	// Update is called once per frame
	void Update () {

		if (FlappyBirdScript.inGame) {

		}

		// Moves anchor
		transform.Translate (Vector2.left * velocity * Time.deltaTime);

		// Verifies limit and return anchor
		if (transform.position.x <= limitX) {
			transform.position = new Vector2( limitX * -1, Random.Range(initialHeight, finalHeight));
		}

	}

	void onTriggerEnter2D(Collider2D c) {

	}
}
