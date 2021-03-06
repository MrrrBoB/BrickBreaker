﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


	public static GameManager instance = null;
	public static int brickCount=0;

	void Awake ()//singleton
	{
		//If instance is empty, create instance
		if (instance == null)
			instance = this;
		//If instance is not *this* then destroy it
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

	}

	public void CCursor ()
	{
		if (SceneManager.GetActiveScene ().buildIndex == 2 || SceneManager.GetActiveScene ().buildIndex == 3 || SceneManager.GetActiveScene ().buildIndex == 4)
			Cursor.visible = false;
		else
			Cursor.visible = true;
	}
	public void LoadLevel(string Level)
	{
		
		SceneManager.LoadScene (Level);
		brickCount = 0;
	}

	public void LoadNextLevel(){
		
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
		brickCount = 0;
	}
	public void QuitGame(){
		Debug.Log ("Quit Game");
		Application.Quit (); 
	}

}
