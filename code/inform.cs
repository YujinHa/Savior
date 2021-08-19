using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inform : MonoBehaviour {
	public GameObject startButton;
	public GameObject informing;
	public GameObject informing2;
	public GameObject informButton;
	public GameObject returnButton;

	public GameObject nextButton;
	public GameObject beforeButton;
	public bool isinformed = false;
//	public bool informcheck = false;

	void Start () {
		informing.SetActive (false);
		informing2.SetActive (false);
		informButton.SetActive (true);
		nextButton.SetActive (false);
		beforeButton.SetActive (false);
		startButton.SetActive (true);
	}

	void Update () {
		
	}
	void Inform ()
	{
		if(isinformed.Equals(false)/*&&informcheck.Equals(false)*/){
			informing.SetActive(true);
			informing2.SetActive (false);
			informButton.SetActive (false);
			startButton.SetActive (false);
			isinformed = true;
	//		informcheck = false;
			nextButton.SetActive (true);
			returnButton.SetActive (true);
	//		beforeButton.SetActive (false);
		}
	/*	else if(isinformed.Equals(true) && informcheck.Equals(false)){
			informing.SetActive(false);
			informing2.SetActive (true);
			informButton.SetActive (false);
			startButton.SetActive (false);
			isinformed = true;
			informcheck = true;
			nextButton.SetActive (false);
			beforeButton.SetActive (true);
		}*/
		else{
			informing.SetActive (false);
			informing2.SetActive (false);
			informButton.SetActive (true);
			startButton.SetActive (true);
			isinformed = false;
			GameObject.Find ("inform_next").GetComponent<inform_next> ().informcheck = false;
			nextButton.SetActive (false);
			beforeButton.SetActive (false);
			returnButton.SetActive (false);
		}
	}
}
