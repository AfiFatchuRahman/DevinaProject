using UnityEngine;
using System.Collections;
using DG.Tweening;

public class AnimationsScripts : MonoBehaviour {

	public GameObject[] breads;

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
		breads [0].transform.DOMove (new Vector3(0.525f, -1.081f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [1].transform.DOMove (new Vector3(2.624f, -1.081f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [2].transform.DOMove (new Vector3(4.748f, -1.081f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [3].transform.DOMove (new Vector3(1f, -1.081f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);		
		breads [4].transform.DOMove (new Vector3(3.066f, -1.081f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [5].transform.DOMove (new Vector3(5.195f, -1.081f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [6].transform.DOMove (new Vector3(0.585f, -0.899f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [7].transform.DOMove (new Vector3(2.725f, -0.899f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [8].transform.DOMove (new Vector3(4.834f, -0.899f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [9].transform.DOMove (new Vector3(1.012f, -0.899f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [10].transform.DOMove (new Vector3(3.134f, -0.899f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
		breads [11].transform.DOMove (new Vector3(5.274f, -0.899f+0.2f, 0), 1f);
		yield return new WaitForSeconds (1f);	
	}
}
