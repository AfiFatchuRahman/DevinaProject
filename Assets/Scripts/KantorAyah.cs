using UnityEngine;
using System.Collections;
using DG.Tweening;

public class KantorAyah : MonoBehaviour {

	public GameObject[] oranges;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play()
	{
		StartCoroutine (PlayAnimation());
	}

	IEnumerator PlayAnimation()
	{
		yield return new WaitForSeconds (1f);
		oranges [0].transform.DOMove (new Vector3(0.884f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [1].transform.DOMove (new Vector3(1.137f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [2].transform.DOMove (new Vector3(1.39f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [3].transform.DOMove (new Vector3(1.65f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);		
		oranges [4].transform.DOMove (new Vector3(1.01f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [5].transform.DOMove (new Vector3(1.509f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [6].transform.DOMove (new Vector3(-0.35f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [7].transform.DOMove (new Vector3(-0.097f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [8].transform.DOMove (new Vector3(0.156f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [9].transform.DOMove (new Vector3(0.416f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [10].transform.DOMove (new Vector3(-0.224f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [11].transform.DOMove (new Vector3(0.275f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [12].transform.DOMove (new Vector3(-0.35f - 1.234f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [13].transform.DOMove (new Vector3(-0.097f - 1.234f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [14].transform.DOMove (new Vector3(0.156f - 1.234f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [15].transform.DOMove (new Vector3(0.416f - 1.234f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [16].transform.DOMove (new Vector3(-0.224f - 1.234f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [17].transform.DOMove (new Vector3(0.275f - 1.234f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [18].transform.DOMove (new Vector3(-0.35f - 2.468f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [19].transform.DOMove (new Vector3(-0.097f - 2.468f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [20].transform.DOMove (new Vector3(0.156f - 2.468f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [21].transform.DOMove (new Vector3(0.416f - 2.468f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [22].transform.DOMove (new Vector3(-0.224f - 2.468f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [23].transform.DOMove (new Vector3(0.275f - 2.468f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [24].transform.DOMove (new Vector3(-0.35f - 3.702f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [25].transform.DOMove (new Vector3(-0.097f - 3.702f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [26].transform.DOMove (new Vector3(0.156f - 3.702f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [27].transform.DOMove (new Vector3(0.416f - 3.702f, 0.018f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [28].transform.DOMove (new Vector3(-0.224f - 3.702f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		oranges [29].transform.DOMove (new Vector3(0.275f - 3.702f, 0.202f, 0), 1f);
		yield return new WaitForSeconds (1f);
	}
}
