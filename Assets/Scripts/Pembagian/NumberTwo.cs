using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberTwo : MonoBehaviour {
	public GameObject[] Books;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play()
	{
		StartCoroutine (PlayAnimation ());
	}

	IEnumerator PlayAnimation()
	{
		yield return new WaitForSeconds (1f);
		Books [1].transform.DOMove (new Vector3 (-0.5f - 1.69f, -0.025f, 0), 1f);
		yield return new WaitForSeconds (1f);
		Books [3].transform.DOMove (new Vector3 (-0.5f - 1.69f, -0.025f + 0.17f, 0), 1f);
		yield return new WaitForSeconds (1f);
		Books [5].transform.DOMove (new Vector3 (-0.5f - 1.69f, -0.025f + 0.34f, 0), 1f);
		yield return new WaitForSeconds (1f);
		Books [7].transform.DOMove (new Vector3 (-0.5f - 1.69f, -0.025f + 0.34f+ 0.17f, 0), 1f);
		yield return new WaitForSeconds (1f);
		Books [9].transform.DOMove (new Vector3 (-0.5f - 1.69f, -0.025f + 0.34f+ 0.17f+ 0.17f, 0), 1f);


		yield return new WaitForSeconds (1f);
		Books[0].transform.DOMove(new Vector3(-0.5f - 3.1f,-0.025f,0), 1f);
		yield return new WaitForSeconds (1f);
		Books[2].transform.DOMove(new Vector3(-0.5f - 3.1f,-0.025f + 0.17f,0), 1f);
		yield return new WaitForSeconds (1f);
		Books[4].transform.DOMove(new Vector3(-0.5f - 3.1f,-0.025f + 0.34f,0), 1f);
		yield return new WaitForSeconds (1f);
		Books[6].transform.DOMove(new Vector3(-0.5f - 3.1f,-0.025f + 0.34f + 0.17f,0), 1f);
		yield return new WaitForSeconds (1f);
		Books[8].transform.DOMove(new Vector3(-0.5f - 3.1f,-0.025f + 0.34f+ 0.17f+ 0.17f,0), 1f);
		yield return new WaitForSeconds (1f);

	}
}
