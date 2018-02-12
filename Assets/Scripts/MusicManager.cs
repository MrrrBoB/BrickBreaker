using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {
	
	public static MusicManager instance = null;

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

}
