using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberEight : MonoBehaviour {

	public GameObject[] mangoes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play()
	{
		
		StartCoroutine(PlayAnimation());
	}
		
	IEnumerator PlayAnimation()
	{
		yield return new WaitForSeconds (1f);
		mangoes [0].transform.DOMove (new Vector3 (1.65f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [1].transform.DOMove (new Vector3 (1.65f + 1.85f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [2].transform.DOMove (new Vector3 (1.65f + 1.85f + 1.55f, -1.95f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [3].transform.DOMove (new Vector3 (1.65f + 0.15f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [4].transform.DOMove (new Vector3 (1.65f + 0.15f + 1.85f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [5].transform.DOMove (new Vector3 (1.65f + 0.15f + 1.85f + 1.55f, -1.95f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [6].transform.DOMove (new Vector3 (1.65f + 0.15f + 0.15f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [7].transform.DOMove (new Vector3 (1.65f + 0.15f + 0.15f + 1.85f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [8].transform.DOMove (new Vector3 (1.65f + 0.15f + 0.15f + 1.85f + 1.55f, -1.95f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [9].transform.DOMove (new Vector3 (1.65f + 0.15f + 0.15f + 0.15f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [10].transform.DOMove (new Vector3 (1.65f + 0.15f + 0.15f + 0.15f + 1.85f, -1.95f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [11].transform.DOMove (new Vector3 (1.65f + 0.15f + 0.15f + 0.15f + 1.85f + 1.55f, -1.95f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [12].transform.DOMove (new Vector3 (1.6f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [13].transform.DOMove (new Vector3 (1.6f + 1.85f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [14].transform.DOMove (new Vector3 (1.6f + 1.85f + 1.55f, -1.95f + 0.2f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [15].transform.DOMove (new Vector3 (1.6f + 0.15f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [16].transform.DOMove (new Vector3 (1.6f + 0.15f + 1.85f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [17].transform.DOMove (new Vector3 (1.6f + 0.15f + 1.85f + 1.55f, -1.95f + 0.2f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [18].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [19].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 1.85f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [20].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 1.85f + 1.55f, -1.95f + 0.2f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [21].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 0.15f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [22].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 0.15f + 1.85f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [23].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 0.15f + 1.85f + 1.55f, -1.95f + 0.2f, -1f), 1f);

		yield return new WaitForSeconds (1f);
		mangoes [24].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 0.15f + 0.15f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [25].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 0.15f + 0.15f + 1.85f, -1.95f + 0.2f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		mangoes [26].transform.DOMove (new Vector3 (1.6f + 0.15f + 0.15f + 0.15f + 0.15f + 1.85f + 1.55f, -1.95f + 0.2f, -1f), 1f);


	}
}
