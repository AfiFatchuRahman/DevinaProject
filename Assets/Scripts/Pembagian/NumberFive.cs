﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NumberFive : MonoBehaviour {

	public GameObject[] marbels;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void play()
	{
		StartCoroutine (PlayAnimation());
	}

	IEnumerator PlayAnimation()
	{
		yield return new WaitForSeconds (1f);
		marbels [33].transform.DOMove (new Vector3(-0.22f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [34].transform.DOMove (new Vector3(-0.05f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [23].transform.DOMove (new Vector3(0.12f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [0].transform.DOMove (new Vector3(0.12f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [11].transform.DOMove (new Vector3(-0.05f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [35].transform.DOMove (new Vector3(-0.22f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [21].transform.DOMove (new Vector3(-0.22f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [1].transform.DOMove (new Vector3(-0.05f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [10].transform.DOMove (new Vector3(0.12f,-0.88f,-1f),1f);
		yield return new WaitForSeconds(1f);
		marbels [36].transform.DOMove (new Vector3(-0.22f + 0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [22].transform.DOMove (new Vector3(-0.05f + 0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [2].transform.DOMove (new Vector3(0.12f+ 0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [9].transform.DOMove (new Vector3(0.12f+ 0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [37].transform.DOMove (new Vector3(-0.05f+ 0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [20].transform.DOMove (new Vector3(-0.22f+ 0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [3].transform.DOMove (new Vector3(-0.22f+ 0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [8].transform.DOMove (new Vector3(-0.05f+ 0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [30].transform.DOMove (new Vector3(0.12f+ 0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds(1f);
		marbels [19].transform.DOMove (new Vector3(-0.22f + 0.7f + 0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [4].transform.DOMove (new Vector3(-0.05f + 0.7f+ 0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [7].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [39].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [24].transform.DOMove (new Vector3(-0.05f+ 0.7f+ 0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [5].transform.DOMove (new Vector3(-0.22f+ 0.7f+ 0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [6].transform.DOMove (new Vector3(-0.22f+ 0.7f+ 0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [40].transform.DOMove (new Vector3(-0.05f+ 0.7f+ 0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [25].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds(1f);
		marbels [13].transform.DOMove (new Vector3(-0.22f + 0.7f + 0.7f +0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [12].transform.DOMove (new Vector3(-0.05f + 0.7f+ 0.7f +0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [41].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f +0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [26].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f +0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [15].transform.DOMove (new Vector3(-0.05f+ 0.7f+ 0.7f+0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [16].transform.DOMove (new Vector3(-0.22f+ 0.7f+ 0.7f+0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [42].transform.DOMove (new Vector3(-0.22f+ 0.7f+ 0.7f+0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [27].transform.DOMove (new Vector3(-0.05f+ 0.7f+ 0.7f+0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [18].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f+0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds(1f);
		marbels [17].transform.DOMove (new Vector3(-0.22f + 0.7f + 0.7f +0.7f+0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [44].transform.DOMove (new Vector3(-0.05f + 0.7f+ 0.7f +0.7f+0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [38].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f +0.7f +0.7f,-1.23f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [29].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f +0.7f+0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [28].transform.DOMove (new Vector3(-0.05f+ 0.7f+ 0.7f+0.7f+0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [43].transform.DOMove (new Vector3(-0.22f+ 0.7f+ 0.7f+0.7f+0.7f,-1.05f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [32].transform.DOMove (new Vector3(-0.22f+ 0.7f+ 0.7f+0.7f+0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [31].transform.DOMove (new Vector3(-0.05f+ 0.7f+ 0.7f+0.7f+0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds (1f);
		marbels [14].transform.DOMove (new Vector3(0.12f+ 0.7f+ 0.7f+0.7f+0.7f,-0.88f,-1f),1f);
		yield return new WaitForSeconds(1f);
	}
}
