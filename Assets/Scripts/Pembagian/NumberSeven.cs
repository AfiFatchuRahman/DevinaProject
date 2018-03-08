using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberSeven : MonoBehaviour {
	public GameObject adik;
	public GameObject[] apples;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play()
	{
		StartCoroutine (playAnimation ());
	}

	IEnumerator playAnimation()
	{
		yield return new WaitForSeconds (1f);
		apples [0].transform.DOMove (new Vector3(1.1f,-0.5f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [1].transform.DOMove (new Vector3(1.9f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [2].transform.DOMove (new Vector3(1.1f + 3.3f,-0.5f,-1f),1f);
		yield return new WaitForSeconds (1f);


		apples [3].transform.DOMove (new Vector3(1.3f,-0.5f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [4].transform.DOMove (new Vector3(1.9f + 0.2f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [5].transform.DOMove (new Vector3(1.1f + 3.3f + 0.2f,-0.5f,-1f),1f);
		yield return new WaitForSeconds (1f);


		apples [6].transform.DOMove (new Vector3(1f,-0.3f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [7].transform.DOMove (new Vector3(1.9f - 0.1f,-1.4f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [8].transform.DOMove (new Vector3(1.1f - 0.1f + 3.3f,-0.5f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);


		apples [9].transform.DOMove (new Vector3(1.2f,-0.3f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [10].transform.DOMove (new Vector3(1.9f - 0.1f + 0.2f,-1.4f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [11].transform.DOMove (new Vector3(1.1f - 0.1f + 3.3f + 0.2f,-0.5f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);

		apples [12].transform.DOMove (new Vector3(1.4f,-0.3f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [13].transform.DOMove (new Vector3(1.9f - 0.1f + 0.2f + 0.2f,-1.4f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [14].transform.DOMove (new Vector3(1.1f - 0.1f + 3.3f + 0.2f + 0.2f,-0.5f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);

		apples [15].transform.DOMove (new Vector3(1.1f,-0.1f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [16].transform.DOMove (new Vector3(1.9f,-1.4f + 0.4f ,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [17].transform.DOMove (new Vector3(1.1f + 3.3f,-0.5f + 0.4f,-1f),1f);
		yield return new WaitForSeconds (1f);


		apples [18].transform.DOMove (new Vector3(1.3f,-0.1f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [19].transform.DOMove (new Vector3(1.9f + 0.2f,-1.4f + 0.4f ,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [20].transform.DOMove (new Vector3(1.1f + 3.3f + 0.2f,-0.5f + 0.4f,-1f),1f);
		yield return new WaitForSeconds (1f);

		apples [21].transform.DOMove (new Vector3(1.1f + 0.1f,-0.1f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [22].transform.DOMove (new Vector3(1.9f +  0.1f,-1.4f + 0.4f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);
		apples [23].transform.DOMove (new Vector3(1.1f + 3.3f + 0.1f,-0.5f + 0.4f + 0.2f,-1f),1f);
		yield return new WaitForSeconds (1f);

	}
		
}
