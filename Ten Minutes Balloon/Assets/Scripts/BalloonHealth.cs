using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonHealth : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D collision) {
		if(collision.gameObject.tag=="Obstacle"){
			GameObject.Find ("GameSessionController").GetComponent<GameSessionController> ().endGame ();
		}
	}
}
