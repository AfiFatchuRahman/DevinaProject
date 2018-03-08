using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberFour : MonoBehaviour {
	public GameObject[] oranges;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause()
	{
		GameObject.FindWithTag ("Pause").GetComponent<RectTransform> ().offsetMax = new Vector2 (0,0); 
		GameObject.FindWithTag ("Pause").GetComponent<RectTransform> ().offsetMin = new Vector2 (0,0); 
	}

	public void play()
	{
		StartCoroutine (PlayAnimation ());	
	}

	IEnumerator PlayAnimation()
	{
		yield return new WaitForSeconds (1f);
		oranges [19].transform.DOMove (new Vector3(0.90f,0.12f,0f),1f);
<<<<<<< HEAD
		yield return new WaitForSeconds (1f);
		oranges [18].transform.DOMove (new Vector3(-0.20f,0.25f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [17].transform.DOMove (new Vector3(-1.40f,0.05f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [16].transform.DOMove (new Vector3(-2.80f,0.1f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [15].transform.DOMove (new Vector3(-3.90f,0.3f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [14].transform.DOMove (new Vector3(0.90f + 0.19f,0.12f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [13].transform.DOMove (new Vector3(-0.20f+ 0.19f,0.25f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [12].transform.DOMove (new Vector3(-1.40f+ 0.19f,0.05f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [11].transform.DOMove (new Vector3(-2.80f+ 0.19f,0.1f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [10].transform.DOMove (new Vector3(-3.90f+ 0.19f,0.3f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [9].transform.DOMove (new Vector3(0.90f + 0.19f+ 0.19f,0.12f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [8].transform.DOMove (new Vector3(-0.20f+ 0.19f+ 0.19f,0.25f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [7].transform.DOMove (new Vector3(-1.40f+ 0.19f+ 0.19f,0.05f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [6].transform.DOMove (new Vector3(-2.80f+ 0.19f+ 0.19f,0.1f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [5].transform.DOMove (new Vector3(-3.90f+ 0.19f+ 0.19f,0.3f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [4].transform.DOMove (new Vector3(0.90f + 0.10f,0.12f + 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [3].transform.DOMove (new Vector3(-0.20f+ 0.10f,0.25f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [2].transform.DOMove (new Vector3(-1.40f+ 0.10f,0.05f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [1].transform.DOMove (new Vector3(-2.80f+ 0.10f,0.1f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [0].transform.DOMove (new Vector3(-3.90f+ 0.10f,0.3f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
=======
		yield return new WaitForSeconds (1f);
		oranges [18].transform.DOMove (new Vector3(-0.20f,0.25f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [17].transform.DOMove (new Vector3(-1.40f,0.05f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [16].transform.DOMove (new Vector3(-2.80f,0.1f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [15].transform.DOMove (new Vector3(-3.90f,0.3f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [14].transform.DOMove (new Vector3(0.90f + 0.19f,0.12f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [13].transform.DOMove (new Vector3(-0.20f+ 0.19f,0.25f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [12].transform.DOMove (new Vector3(-1.40f+ 0.19f,0.05f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [11].transform.DOMove (new Vector3(-2.80f+ 0.19f,0.1f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [10].transform.DOMove (new Vector3(-3.90f+ 0.19f,0.3f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [9].transform.DOMove (new Vector3(0.90f + 0.19f+ 0.19f,0.12f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [8].transform.DOMove (new Vector3(-0.20f+ 0.19f+ 0.19f,0.25f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [7].transform.DOMove (new Vector3(-1.40f+ 0.19f+ 0.19f,0.05f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [6].transform.DOMove (new Vector3(-2.80f+ 0.19f+ 0.19f,0.1f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [5].transform.DOMove (new Vector3(-3.90f+ 0.19f+ 0.19f,0.3f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [4].transform.DOMove (new Vector3(0.90f + 0.10f,0.12f + 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [3].transform.DOMove (new Vector3(-0.20f+ 0.10f,0.25f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [2].transform.DOMove (new Vector3(-1.40f+ 0.10f,0.05f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [1].transform.DOMove (new Vector3(-2.80f+ 0.10f,0.1f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
		oranges [0].transform.DOMove (new Vector3(-3.90f+ 0.10f,0.3f+ 0.13f,0f),1f);
		yield return new WaitForSeconds (1f);
>>>>>>> 998535260729c7f2448086e1f58fd28a88571f79


	}
}
