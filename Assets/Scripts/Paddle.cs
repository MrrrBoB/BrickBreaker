using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	public bool autoPlay;
	private GameObject ball;
	private void Start () {
		ball = FindObjectOfType<Ball> ().gameObject; 
	}


	void Update () {
		
		//get current paddle position
		Vector3 paddlePosition = new Vector3 (0, gameObject.transform.position.y,0);
		if (autoPlay) {
			paddlePosition.x = ball.transform.position.x;
		}
		else {
		//get mouse position
		float mouseX = Input.mousePosition.x/Screen.width*28-14;
		//convert mouse position to world space
		//save new position
			paddlePosition.x=mouseX;}
		//set this paddle object to saved position
		this.gameObject.transform.position = paddlePosition;
	}
}
