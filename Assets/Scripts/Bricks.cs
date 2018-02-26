using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bricks : MonoBehaviour {
	public int health; 
	public Sprite[] brickStates;


	private void Awake() {
		GameManager.brickCount++;
		print (GameManager.brickCount);
		GetComponent<SpriteRenderer> ().sprite = brickStates [health-1];
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
		else 
			GetComponent<SpriteRenderer> ().sprite = brickStates [health-1];
	}

	//If health reaches 0, destroy

}
