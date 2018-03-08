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
		candies [0].transform.DOMove (new Vector3(-1.3f + 0.2f,-0.9f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [1].transform.DOMove (new Vector3(-1.3f + 2.1f+ 0.2f,-0.90f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [2].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 0.2f,-0.90f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [3].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 2.1f + 0.2f,-0.90f,0f),1f);

		yield return new WaitForSeconds (1f);
		candies [4].transform.DOMove (new Vector3(-1.3f + 0.2f+0.3f,-0.9f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [5].transform.DOMove (new Vector3(-1.3f + 2.1f+ 0.2f+0.3f,-0.90f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [6].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 0.2f+0.3f,-0.90f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [7].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 2.1f + 0.2f+0.3f,-0.90f,0f),1f);

		yield return new WaitForSeconds (1f);
		candies [8].transform.DOMove (new Vector3(-1.3f + 0.2f+0.3f+0.3f,-0.9f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [9].transform.DOMove (new Vector3(-1.3f + 2.1f+ 0.2f+0.3f+0.3f,-0.90f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [10].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 0.2f+0.3f+0.3f,-0.90f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [11].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 2.1f + 0.2f+0.3f+0.3f,-0.90f,0f),1f);

		yield return new WaitForSeconds (1f);
		candies [12].transform.DOMove (new Vector3(-1.3f + 0.2f,-0.9f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [13].transform.DOMove (new Vector3(-1.3f + 2.1f+ 0.2f,-0.90f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [14].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 0.2f,-0.90f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [15].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 2.1f + 0.2f,-0.90f+ 0.2f,0f),1f);

		yield return new WaitForSeconds (1f);
		candies [16].transform.DOMove (new Vector3(-1.3f + 0.2f+0.3f,-0.9f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [17].transform.DOMove (new Vector3(-1.3f + 2.1f+ 0.2f+0.3f,-0.90f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [18].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 0.2f+0.3f,-0.90f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [19].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 2.1f + 0.2f+0.3f,-0.90f+ 0.2f,0f),1f);

		yield return new WaitForSeconds (1f);
		candies [20].transform.DOMove (new Vector3(-1.3f + 0.2f+0.3f+0.3f,-0.9f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [21].transform.DOMove (new Vector3(-1.3f + 2.1f+ 0.2f+0.3f+0.3f,-0.90f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [22].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 0.2f+0.3f+0.3f,-0.90f+ 0.2f,0f),1f);
		yield return new WaitForSeconds (1f);
		candies [23].transform.DOMove (new Vector3(-1.3f + 2.1f + 2.1f + 2.1f + 0.2f+0.3f+0.3f,-0.90f+ 0.2f,0f),1f);


	}
}
