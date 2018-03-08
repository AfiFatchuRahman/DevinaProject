using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberSix : MonoBehaviour {

	public GameObject[] Tomtoes;

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
		Tomtoes[24].transform.DOMove(new Vector3(-2f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[23].transform.DOMove(new Vector3(-2f - 1.1f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[22].transform.DOMove(new Vector3(-2f - 1.1f - 1.1f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[21].transform.DOMove(new Vector3(-2f - 1.1f - 1.1f,-1.4f + 0.6f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[20].transform.DOMove(new Vector3(-2f - 1.1f - 1.1f - 1.1f,-1.4f + 0.6f,-1f),1f);


		yield return new WaitForSeconds (1f);
		Tomtoes[19].transform.DOMove(new Vector3(-2f - 0.30f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes [18].transform.DOMove (new Vector3 (-2f - 0.3f - 1.1f, -1.4f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		Tomtoes [17].transform.DOMove (new Vector3 (-2f - 0.3f - 1.1f - 1.1f ,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[16].transform.DOMove(new Vector3(-2f - 0.3f - 1.1f - 1.1f,-1.4f + 0.6f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[15].transform.DOMove(new Vector3(-2f - 0.3f - 1.1f - 1.1f - 1.1f,-1.4f + 0.6f,-1f),1f);

		yield return new WaitForSeconds (1f);
		Tomtoes[14].transform.DOMove(new Vector3(-2f - 0.30f - 0.3f,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes [13].transform.DOMove (new Vector3 (-2f - 0.3f - 0.3f- 1.1f, -1.4f, -1f), 1f);
		yield return new WaitForSeconds (1f);
		Tomtoes [12].transform.DOMove (new Vector3 (-2f - 0.3f - 1.1f- 0.3f - 1.1f ,-1.4f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[11].transform.DOMove(new Vector3(-2f - 0.3f - 1.1f - 1.1f- 0.3f,-1.4f + 0.6f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[10].transform.DOMove(new Vector3(-2f - 0.3f - 1.1f - 1.1f - 1.1f - 0.3f,-1.4f + 0.6f,-1f),1f);


		yield return new WaitForSeconds (1f);
		Tomtoes[9].transform.DOMove(new Vector3(-2f - 0.17f,-1.4f + 0.25f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[8].transform.DOMove(new Vector3(-2f - 0.17f - 1.1f,-1.4f + 0.25f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[7].transform.DOMove(new Vector3(-2f - 0.17f - 1.1f - 1.1f,-1.4f + 0.25f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[6].transform.DOMove(new Vector3(-2f - 0.17f - 1.1f - 1.1f,-1.4f + 0.25f + 0.6f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[5].transform.DOMove(new Vector3(-2f - 0.17f - 1.1f - 1.1f - 1.1f,-1.4f + 0.25f + 0.6f,-1f),1f);

		yield return new WaitForSeconds (1f);
		Tomtoes[4].transform.DOMove(new Vector3(-2f - 0.17f- 0.3f,-1.4f + 0.25f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[3].transform.DOMove(new Vector3(-2f - 0.17f - 0.3f- 1.1f,-1.4f + 0.25f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[2].transform.DOMove(new Vector3(-2f - 0.17f - 0.3f- 1.1f - 1.1f,-1.4f + 0.25f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[1].transform.DOMove(new Vector3(-2f - 0.17f - 0.3f- 1.1f - 1.1f,-1.4f + 0.25f + 0.6f,-1f),1f);
		yield return new WaitForSeconds (1f);
		Tomtoes[0].transform.DOMove(new Vector3(-2f - 0.17f - 0.3f- 1.1f - 1.1f - 1.1f,-1.4f + 0.25f + 0.6f,-1f),1f);
	}
		
}
