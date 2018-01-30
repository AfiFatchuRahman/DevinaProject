using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AnswerControl : MonoBehaviour {

	public string answer;
	public string key;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CekAnswer()
	{
		if (answer == key) {
			print ("Benar");
		} else {
			print ("Salah");
		}
	}
}
