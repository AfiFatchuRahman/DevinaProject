using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AnswerControl : MonoBehaviour {

	public string answer;
	public string key;

	Sprite[] lockAnswerImg = new Sprite[4];

	// Use this for initialization
	void Start () {
		lockAnswerImg[0] = Resources.Load<Sprite>("GlobalAssets/btn1");	
		lockAnswerImg[1] = Resources.Load<Sprite>("GlobalAssets/btn2");	
		lockAnswerImg[2] = Resources.Load<Sprite>("GlobalAssets/btn3");	
		lockAnswerImg[3] = Resources.Load<Sprite>("GlobalAssets/btn4");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CekAnswer()
	{
		lockAnswer ();
		SelectAndDisableButton (this.gameObject.name, true);
		Invoke ("Result", 1f);
	}

	private void Result()
	{
		if (answer == key) {
			print ("Benar");
			StartCoroutine(AnswerClip (true));
		} else {
			print ("Salah");
			StartCoroutine(AnswerClip (false));
		}		
	}

	private void lockAnswer()
	{
		this.GetComponent<Image> ().sprite = lockAnswerImg[1];
	}

	private void unlockAnswer()
	{
		this.GetComponent<Image> ().sprite = lockAnswerImg[0];
	}

	private void SelectAndDisableButton(string key, bool state)
	{
		switch(key)
		{
		case "A":
			DisableButton(GameObject.Find (key), state);
			DisableButton(GameObject.Find ("B"), state);
			DisableButton(GameObject.Find ("C"), state);
			DisableButton(GameObject.Find ("D"), state);
			break;
		case "B":
			DisableButton(GameObject.Find (key), state);
			DisableButton(GameObject.Find ("A"), state);
			DisableButton(GameObject.Find ("C"), state);
			DisableButton(GameObject.Find ("D"), state);
			break;
		case "C":
			DisableButton(GameObject.Find (key), state);
			DisableButton(GameObject.Find ("B"), state);
			DisableButton(GameObject.Find ("A"), state);
			DisableButton(GameObject.Find ("D"), state);
			break;
		case "D":
			DisableButton(GameObject.Find (key), state);
			DisableButton(GameObject.Find ("B"), state);
			DisableButton(GameObject.Find ("C"), state);
			DisableButton(GameObject.Find ("A"), state);
			break;
		}
	}

	private void DisableButton(GameObject btn, bool state)
	{
		if (state) 
		{
			btn.GetComponent<Button> ().enabled = false;			
		} else 
		{
			btn.GetComponent<Button> ().enabled = true;
		}
	}

	IEnumerator AnswerClip(bool state)	{
		if (state) {
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [2];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [2];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [2];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [2];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [2];
		} else 
		{
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [3];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [3];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [3];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [3];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [1];
			yield return new WaitForSeconds (0.1f);
			this.GetComponent<Image> ().sprite = lockAnswerImg [3];
		}
	}
}