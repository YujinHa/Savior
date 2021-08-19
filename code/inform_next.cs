using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inform_next : MonoBehaviour {
	public GameObject informing;
	public GameObject informing2;
	public GameObject returnButton;
	public GameObject nextButton;
	public GameObject beforeButton;
//	public bool isinformed = false;
	public bool informcheck = false;

	void Start () {
		informing.SetActive (false);
		informing2.SetActive (false);
		nextButton.SetActive (false);
		beforeButton.SetActive (false);
	}

	void Update () {

	}
	void Inform ()
	{
		if (/*isinformed.Equals (true) && */informcheck.Equals (false)) {
			informing.SetActive (false);
			informing2.SetActive (true);
		//	isinformed = true;
			informcheck = true;
			nextButton.SetActive (false);
			beforeButton.SetActive (true);
			returnButton.SetActive (true);
			GameObject.Find ("main_menu_manager").GetComponent<inform> ().returnButton.SetActive(true);
		} else if (/*isinformed.Equals (true) && */informcheck.Equals (true)) {
			informing.SetActive (true);
			informing2.SetActive (false);
		//	isinformed = true;
			informcheck = false;
			nextButton.SetActive (true);
			beforeButton.SetActive (false);
			returnButton.SetActive (true);
			GameObject.Find ("main_menu_manager").GetComponent<inform> ().returnButton.SetActive(true);
		}
	}
}
