using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Resume()
	{
		GameObject.FindWithTag ("Pause").GetComponent<RectTransform> ().offsetMax = new Vector2 (0,829); 
		GameObject.FindWithTag ("Pause").GetComponent<RectTransform> ().offsetMin = new Vector2 (0,829); 
	}

	public void Restart(){
		//Application.LoadLevel (this);
	}

	public void Level(){
		Application.LoadLevel ("Level");
	}

	public void Home(){
		Application.LoadLevel ("Menu");
	}
}
