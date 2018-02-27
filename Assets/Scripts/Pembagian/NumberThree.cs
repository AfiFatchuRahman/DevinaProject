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

	public void Pause()
	{
		GameObject.FindWithTag ("Pause").GetComponent<RectTransform> ().offsetMax = new Vector2 (0,0); 
		GameObject.FindWithTag ("Pause").GetComponent<RectTransform> ().offsetMin = new Vector2 (0,0); 
	}

	public void play()
	{
		StartCoroutine (PlayAnimasi());
	}

	IEnumerator PlayAnimasi()
	{
		yield return new WaitForSeconds (1f);
		Apples [19].transform.DOMove (new Vector3(-4.45f, -1.45f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [18].transform.DOMove (new Vector3 (-4.45f + 3.3f, -1.45f + 0.3f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		Apples [20].transform.DOMove (new Vector3 (-4.45f + 3.3f + 0.7f, -1.45f + 0.3f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		Apples [5].transform.DOMove (new Vector3(-4.45f + 7.35f, -1.45f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [6].transform.DOMove (new Vector3 (-4.45f + 3.3f + 4.95f, -1.45f + 0.3f, -1f), 1f);


		yield return new WaitForSeconds (1f);
		Apples [24].transform.DOMove (new Vector3(-4.45f + 0.2f, -1.45f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [3].transform.DOMove (new Vector3(-4.45f + 0.2f + 3.3f, -1.45f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [4].transform.DOMove (new Vector3(-4.45f + 0.2f + 3.3f + 0.7f, -1.45f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [8].transform.DOMove (new Vector3(-4.45f + 0.2f + 7.35f, -1.45f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [7].transform.DOMove (new Vector3(-4.45f + 0.2f + 3.3f +4.95f, -1.45f + 0.3f, -1f),1f);


		yield return new WaitForSeconds (1f);
		Apples [0].transform.DOMove (new Vector3(-4.45f - 0.05f, -1.45f + 0.2f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [1].transform.DOMove (new Vector3(-4.45f - 0.05f + 3.3f, -1.45f + 0.2f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [2].transform.DOMove (new Vector3(-4.45f - 0.05f + 3.3f + 0.7f, -1.45f + 0.2f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [23].transform.DOMove (new Vector3(-4.45f - 0.05f + 7.35f, -1.45f + 0.2f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [21].transform.DOMove (new Vector3(-4.45f - 0.05f + 3.3f + 4.95f, -1.45f + 0.2f + 0.3f, -1f),1f);

		yield return new WaitForSeconds (1f);
		Apples [22].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f, -1.45f + 0.2f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [17].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f + 3.3f, -1.45f + 0.2f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [16].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f + 3.3f +0.7f, -1.45f + 0.2f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [15].transform.DOMove (new Vector3(-4.45f - 0.05f + 7.35f + 0.18f, -1.45f + 0.2f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [12].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f + 3.3f + 4.95f, -1.45f + 0.2f + 0.3f, -1f),1f);

		yield return new WaitForSeconds (1f);
		Apples [13].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f +0.2f, -1.45f + 0.2f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [14].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f +0.2f +3.3f, -1.45f + 0.2f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [9].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f +0.2f + 3.3f + 0.7f, -1.45f + 0.2f + 0.3f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [10].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f + 0.2f +7.35f, -1.45f + 0.2f, -1f),1f);
		yield return new WaitForSeconds (1f);
		Apples [11].transform.DOMove (new Vector3(-4.45f - 0.05f + 0.18f +0.2f + 3.3f + 4.95f, -1.45f + 0.2f + 0.3f, -1f),1f);
	}
}
