using System.Collections;
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


	public void LoadLevel(string Level)
	{
		SceneManager.LoadScene (Level);
		brickCount = 0;
	}

	public void LoadNextLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
		brickCount = 0;
	}


}
