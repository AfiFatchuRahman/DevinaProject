using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class XNumberTwo : MonoBehaviour {

	public GameObject[] eggs;
	public GameObject[] eggs2;
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

	public void Play()
	{
		StartCoroutine (PlayAnimation());
	}

	IEnumerator PlayAnimation()
	{
		yield return new WaitForSeconds (1f);
		eggs [10].transform.DOMove (new Vector3(1.33f, 0.56f, 0), 1);
		eggs [10].transform.DOScale(new Vector3(2f, 2f, 0), 1);
		yield return new WaitForSeconds (1f);
		eggs [0].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [1].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [2].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [3].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [4].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [5].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [6].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [7].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [8].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1f);
		eggs [9].transform.DOScale (new Vector3(1.5f, 1.5f, 0), 0.25f);
		yield return new WaitForSeconds (1.5f);
		eggs [10].transform.DOMove (new Vector3(-1.49f, -0.89f, eggs[10].transform.position.z), 1);
		eggs [10].transform.DOScale(new Vector3(1f, 1f, 0), 1);
	}
}
