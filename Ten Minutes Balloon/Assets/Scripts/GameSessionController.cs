using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSessionController : MonoBehaviour {

	public Text score;
	public GameObject obstaclePrefab;
	public GameObject player;
	public GameObject Balloon;

	private int gameScore = -10;

	// Use this for initialization
	void Start () {
		StartCoroutine ("Spawnner");
	}

	public void spawnObstacle(){
		GameObject obstacle = Instantiate (obstaclePrefab) as GameObject;
		obstacle.transform.localScale = new Vector3 (Random.Range(0.05f, 0.9f), Random.Range(0.05f, 0.5f),1f);
	}

	IEnumerator Spawnner(){
		while(true==true){
		spawnObstacle ();
		gameScore += 10;
		score.text = gameScore.ToString();
		yield return new WaitForSeconds (1f);
		}
	}

	public void endGame(){
		StopAllCoroutines ();
		score.text = "Game Over: " + gameScore;
		Destroy (player);
		Destroy (Balloon);
		GameObject[] allObstacles = GameObject.FindGameObjectsWithTag ("Obstacle");
		for(int i=0; i<allObstacles.Length; i++){
			Destroy (allObstacles[i]);
		}
	}
}
