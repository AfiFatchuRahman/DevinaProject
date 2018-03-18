using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberThree : MonoBehaviour {

	public GameObject[] Apples;

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
		Apples [8].transform.DOMove (new Vector3(-2.74f,-1.14f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [7].transform.DOMove (new Vector3(-2.74f + 5.6f,-1.14f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [6].transform.DOMove (new Vector3(-2.74f + 5.6f + 1.2f,-1.14f,-1f),1f);


		yield return new WaitForSeconds (1f);
		Apples [5].transform.DOMove (new Vector3(-2.74f + 0.17f,-1.14f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [4].transform.DOMove (new Vector3(-2.74f + 0.17f + 5.6f ,-1.14f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [3].transform.DOMove (new Vector3(-2.74f + 0.17f + 5.6f + 1.2f,-1.14f,-1f),1f);

		yield return new WaitForSeconds (1f);
		Apples [2].transform.DOMove (new Vector3(-2.74f + 0.17f + 0.17f,-1.14f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [1].transform.DOMove (new Vector3(-2.74f + 0.17f + 0.17f + 5.6f,-1.14f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [0].transform.DOMove (new Vector3(-2.74f + 0.17f + 0.17f + 5.6f + 1.2f,-1.14f,-1f),1f);

		yield return new WaitForSeconds (1f);
		Apples [17].transform.DOMove (new Vector3(-2.74f ,-1.14f  + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [16].transform.DOMove (new Vector3(-2.74f + 5.6f,-1.14f  + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [15].transform.DOMove (new Vector3(-2.74f+ 5.6f + 1.2f,-1.14f  + 0.2f,-1f),1f);

		yield return new WaitForSeconds (1f);
		Apples [14].transform.DOMove (new Vector3(-2.74f + 0.17f,-1.14f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [13].transform.DOMove (new Vector3(-2.74f + 0.17f + 5.6f,-1.14f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [12].transform.DOMove (new Vector3(-2.74f + 0.17f + 5.6f + 1.2f,-1.14f + 0.2f,-1f),1f);


		yield return new WaitForSeconds (1f);
		Apples [11].transform.DOMove (new Vector3(-2.74f + 0.17f + 0.17f,-1.14f  + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [10].transform.DOMove (new Vector3(-2.74f + 0.17f + 0.17f + 5.6f,-1.14f  + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [9].transform.DOMove (new Vector3(-2.74f + 0.17f + 0.17f + 5.6f + 1.2f,-1.14f  + 0.2f,-1f),1f);
	}
}
