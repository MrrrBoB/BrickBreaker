using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
	public int health; 

	private void Awake() {
		GameManager.brickCount++;
		print (GameManager.brickCount);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{ 
		health--;
		if (health <= 0) {
			GameManager.brickCount--;
			if (GameManager.brickCount <= 0) {
				FindObjectOfType<GameManager> ().LoadNextLevel ();
			}
			Destroy(gameObject);
			print (GameManager.brickCount);
		}
	}

	//If health reaches 0, destroy

}
