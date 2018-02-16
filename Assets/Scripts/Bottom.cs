using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour {
	public GameManager theGameManager;
	// Use this for initialization
	void Start () {
		theGameManager = FindObjectOfType<GameManager> ();	
	}
	private void OnTriggerEnter2D() 
	{
		print ("Over");
		theGameManager.LoadLevel ("GameOver");
	}

}
