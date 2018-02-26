using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour {
	public Vector2 begin;


	public AudioClip Hit;
	void Start() {
		GetComponent<Rigidbody2D> ().AddForce(transform.up*750);
	}


	private void OnCollisionEnter2D(Collision2D collision)
	{
		AudioSource.PlayClipAtPoint (Hit, new Vector3(0,0,0));
	}

}
