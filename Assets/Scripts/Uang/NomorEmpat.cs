using UnityEngine;
using System.Collections;
using DG.Tweening;

public class NomorEmpat : MonoBehaviour {

	public GameObject[] money;

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
		money [0].transform.DOScale (new Vector3 (1, 1, 1), 1f).SetEase(Ease.OutBounce);
		yield return new WaitForSeconds (1f);
		money [1].transform.DOScale (new Vector3 (1, 1, 1), 1f).SetEase(Ease.OutBounce);
		yield return new WaitForSeconds (1f);
		money [2].transform.DOScale (new Vector3 (1, 1, 1), 1f).SetEase(Ease.OutBounce);
		yield return new WaitForSeconds (1f);
		money [3].transform.DOScale (new Vector3 (1, 1, 1), 1f).SetEase(Ease.OutBounce);
	}
}
