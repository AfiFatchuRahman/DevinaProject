using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class NumberOne : MonoBehaviour {

	public GameObject[] candys;

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
		candys [0].transform.DOMove (new Vector3(-1.03f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [0].transform.DOMove (new Vector3(2.299f, -1.226f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [1].transform.DOMove (new Vector3(-1.03f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [1].transform.DOMove (new Vector3(2.483f, -1.268f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [2].transform.DOMove (new Vector3(-1.03f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [2].transform.DOMove (new Vector3(2.751f, -1.247f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [3].transform.DOMove (new Vector3(-1.03f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [3].transform.DOMove (new Vector3(2.431f, -1.126f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [4].transform.DOMove (new Vector3(-1.03f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);		
		candys [4].transform.DOMove (new Vector3(2.668f, -1.137f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [5].transform.DOMove (new Vector3(-1.94f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [5].transform.DOMove (new Vector3(2.757f, -1.382f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [6].transform.DOMove (new Vector3(-1.94f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [6].transform.DOMove (new Vector3(2.298f, -1.353f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [7].transform.DOMove (new Vector3(-1.94f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [7].transform.DOMove (new Vector3(2.412f, -1.412f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [8].transform.DOMove (new Vector3(-1.94f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [8].transform.DOMove (new Vector3(2.333f, -0.979f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [9].transform.DOMove (new Vector3(-1.94f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [9].transform.DOMove (new Vector3(2.721f, -0.962f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [10].transform.DOMove (new Vector3(-1.94f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [10].transform.DOMove (new Vector3(3.103f, -1.289f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [11].transform.DOMove (new Vector3(-2.81f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [11].transform.DOMove (new Vector3(3.032f, -1.1f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [12].transform.DOMove (new Vector3(-2.81f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [12].transform.DOMove (new Vector3(3.124f, -1.181f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [13].transform.DOMove (new Vector3(-2.81f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [13].transform.DOMove (new Vector3(1.941f, -1.247f, 0), 1f);
		yield return new WaitForSeconds (1f);
		candys [14].transform.DOMove (new Vector3(-2.81f, 0.25f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		candys [14].transform.DOMove (new Vector3(1.998f, -1.117f, 0), 1f);
		yield return new WaitForSeconds (1f);
	}
}
