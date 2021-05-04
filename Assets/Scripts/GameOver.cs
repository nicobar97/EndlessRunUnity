using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Obstacle"){
			RestartGame();
		}
	}

	void RestartGame(){
		SceneManager.LoadScene("GameOver");
	}
}