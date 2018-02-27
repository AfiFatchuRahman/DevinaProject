using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour {

	public string level;
	public int kategori;

	// Use this for initialization
	void Start () {
		kategori = PlayerPrefs.GetInt ("kat");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play()
	{
		GoToLevel (level);
		print (level);
	}

	private void GoToLevel(string lvl)
	{
		switch(kategori)
		{
		case 0:
			Application.LoadLevel ("kali"+lvl);
			break;
		case 1:
			Application.LoadLevel ("bagi"+lvl);
			break;
		case 2:
			Application.LoadLevel ("uang"+lvl);
			break;
		}
	}
}
