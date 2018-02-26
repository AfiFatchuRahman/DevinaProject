using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberTen : MonoBehaviour {

	public GameObject[] candies;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play()
	{
		StartCoroutine (PlayAnimasi());
	}

	IEnumerator PlayAnimasi()
	{
		yield return new WaitForSeconds (1f);
		candies [0].transform.DOMove (new Vector3(-1f,-1f,0f),1f);
	}
}
