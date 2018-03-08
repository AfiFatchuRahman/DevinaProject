using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberNine : MonoBehaviour {

	public GameObject [] eggs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play()
	{
		StartCoroutine (playAnimation());
	}

	IEnumerator playAnimation()
	{
		yield return new WaitForSeconds (1f);
		eggs [28].transform.DOMove (new Vector3(-5.65f, -0.9f,-0.018f),1f);
		yield return new WaitForSeconds (1f);
		eggs [7].transform.DOMove (new Vector3(-5.65f + 1.2f, -0.9f,-0.017f),1f);
		yield return new WaitForSeconds (1f);
		eggs [17].transform.DOMove (new Vector3(-5.65f + 1.2f, -0.9f - 0.625f,-0.017f),1f);
		yield return new WaitForSeconds (1f);
		eggs [27].transform.DOMove (new Vector3(-5.65f + 1.2f + 1f, -0.9f - 0.625f,-0.017f),1f);
		yield return new WaitForSeconds (1f);
		eggs [6].transform.DOMove (new Vector3(-5.65f + 1.2f + 1f + 1f, -0.9f - 0.625f,-0.017f),1f);


		yield return new WaitForSeconds (1f);
		eggs [9].transform.DOMove (new Vector3(-5.65f + 0.15f, -0.9f - 0.05f,-0.019f),1f);
		yield return new WaitForSeconds (1f);
		eggs [19].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f, -0.9f - 0.05f,-0.019f),1f);
		yield return new WaitForSeconds (1f);
		eggs [29].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f, -0.9f - 0.05f - 0.625f,-0.019f),1f);
		yield return new WaitForSeconds (1f);
		eggs [8].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f + 1f, -0.9f - 0.05f - 0.625f,-0.019f),1f);
		yield return new WaitForSeconds (1f);
		eggs [18].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f + 1f +1f, -0.9f - 0.05f - 0.625f,-0.019f),1f);

		yield return new WaitForSeconds (1f);
		eggs [16].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f, -0.9f - 0.05f,-0.016f),1f);
		yield return new WaitForSeconds (1f);
		eggs [26].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 1.2f, -0.9f - 0.05f,-0.016f),1f);
		yield return new WaitForSeconds (1f);
		eggs [5].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 1.2f, -0.9f - 0.05f - 0.625f,-0.015f),1f);
		yield return new WaitForSeconds (1f);
		eggs [15].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 1.2f + 1f, -0.9f - 0.05f - 0.625f,-0.015f),1f);
		yield return new WaitForSeconds (1f);
		eggs [25].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 1.2f + 1f + 1f, -0.9f - 0.05f - 0.625f,-0.015f),1f);

		yield return new WaitForSeconds (1f);
		eggs [4].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 0.15f, -0.9f,-0.014f),1f);
		yield return new WaitForSeconds (1f);
		eggs [14].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 0.15f + 1.2f, -0.9f,-0.014f),1f);
		yield return new WaitForSeconds (1f);
		eggs [24].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 0.15f + 1.2f, -0.9f - 0.625f ,-0.014f),1f);
		yield return new WaitForSeconds (1f);
		eggs [3].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 0.15f + 1.2f + 1f, -0.9f - 0.625f ,-0.014f),1f);
		yield return new WaitForSeconds (1f);
		eggs [13].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f + 0.15f + 1.2f + 1f +1f, -0.9f - 0.625f ,-0.014f),1f);

		yield return new WaitForSeconds (1f);
		eggs [11].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f, -0.9f + 0.075f,-0.011f),1f);
		yield return new WaitForSeconds (1f);
		eggs [21].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f +1.2f, -0.9f + 0.075f,-0.011f),1f);
		yield return new WaitForSeconds (1f);
		eggs [0].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f +1.2f, -0.9f + 0.075f - 0.625f,-0.011f),1f);
		yield return new WaitForSeconds (1f);
		eggs [10].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f +1.2f + 1f, -0.9f + 0.075f - 0.625f,-0.011f),1f);
		yield return new WaitForSeconds (1f);
		eggs [20].transform.DOMove (new Vector3(-5.65f + 0.15f + 0.15f +1.2f + 1f + 1f, -0.9f + 0.075f - 0.625f,-0.011f),1f);

		yield return new WaitForSeconds (1f);
		eggs [23].transform.DOMove (new Vector3(-5.65f + 0.15f, -0.9f + 0.075f,-0.013f),1f);
		yield return new WaitForSeconds (1f);
		eggs [2].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f, -0.9f + 0.075f,-0.012f),1f);
		yield return new WaitForSeconds (1f);
		eggs [12].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f, -0.9f + 0.075f -0.625f,-0.012f),1f);
		yield return new WaitForSeconds (1f);
		eggs [22].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f + 1f, -0.9f + 0.075f -0.625f,-0.012f),1f);
		yield return new WaitForSeconds (1f);
		eggs [1].transform.DOMove (new Vector3(-5.65f + 0.15f + 1.2f + 1f +1f, -0.9f + 0.075f -0.625f,-0.012f),1f);
	}
}
