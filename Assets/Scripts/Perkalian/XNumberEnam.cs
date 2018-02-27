using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class XNumberEnam : MonoBehaviour {

	public GameObject[] kelereng;

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
		kelereng [0].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [0].transform.DOMove (new Vector3(1.62f, -0.53f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [1].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [1].transform.DOMove (new Vector3(1.36f, -0.83f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [2].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [2].transform.DOMove (new Vector3(1f, -0.99f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [3].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [3].transform.DOMove (new Vector3(0.93f, -0.7f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [4].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);		
		kelereng [4].transform.DOMove (new Vector3(1.26f, -0.55f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [5].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [5].transform.DOMove (new Vector3(0.59f, -0.89f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [6].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [6].transform.DOMove (new Vector3(0.49f, -0.6f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [7].transform.DOMove (new Vector3(-1.754f, -0.312f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [7].transform.DOMove (new Vector3(0.85f, -0.37f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [8].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [8].transform.DOMove (new Vector3(0.19f, -0.95f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [9].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [9].transform.DOMove (new Vector3(0.15f, -0.67f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [10].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [10].transform.DOMove (new Vector3(0.28f, -0.35f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [11].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [11].transform.DOMove (new Vector3(1.29f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [12].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [12].transform.DOMove (new Vector3(1.62f, -1.01f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [13].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [13].transform.DOMove (new Vector3(0.57f, -0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [14].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [14].transform.DOMove (new Vector3(-0.19f, -0.89f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [15].transform.DOMove (new Vector3(-2.635f, -0.29f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [15].transform.DOMove (new Vector3(-0.19f, -0.54f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [16].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [16].transform.DOMove (new Vector3(1.86f, -0.7f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [17].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [17].transform.DOMove (new Vector3(-0.07f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [18].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [18].transform.DOMove (new Vector3(2.43f, -0.35f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [19].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [19].transform.DOMove (new Vector3(2.35f, -0.68f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [20].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [20].transform.DOMove (new Vector3(2.45f, -1.03f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [21].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [21].transform.DOMove (new Vector3(1.75f, -0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [22].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [22].transform.DOMove (new Vector3(2.04f, -0.42f, 0), 1f);
		yield return new WaitForSeconds (1f);
		kelereng [23].transform.DOMove (new Vector3(-3.539f, -0.24f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		kelereng [23].transform.DOMove (new Vector3(2.08f, -0.97f, 0), 1f);
		yield return new WaitForSeconds (1f);
	}
}
