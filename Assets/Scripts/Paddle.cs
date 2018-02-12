using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {



	void Update () {
		//get current paddle position
		Vector3 paddlePosition = new Vector3 (0, gameObject.transform.position.y,0);
		//get mouse position
		float mouseX = Input.mousePosition.x/Screen.width*16-8;
		//convert mouse position to world space
		//save new position
		paddlePosition.x=mouseX;
		//set this paddle object to saved position
		this.gameObject.transform.position = paddlePosition;
	}
}
