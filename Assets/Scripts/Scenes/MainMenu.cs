using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	int kategori;

	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("kat")) {
			PlayerPrefs.SetInt ("kat", 0);
		} else {
			if(PlayerPrefs.GetInt("kat") != 0)
			{
				PlayerPrefs.SetInt ("kat", 0);
			}
		} 		

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoToKali()
	{
		PlayerPrefs.SetInt ("kat", 0);
		Application.LoadLevel ("Level");
	}

	public void GoToBagi()
	{
		PlayerPrefs.SetInt ("kat", 1);
		Application.LoadLevel ("Level");
	}

	public void GoToUang()
	{
		PlayerPrefs.SetInt ("kat", 2);
		Application.LoadLevel ("Level");
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
