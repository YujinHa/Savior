using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class informReturn : MonoBehaviour {
	public GameObject startButton;
	public GameObject informImage;
	public GameObject informImage2;
	public GameObject informButton;
	public GameObject returnButton;
	public GameObject nextButton;
	public GameObject beforeButton;

	void Start () {
	}

	void Update () {

	}

	public void Click()
	{
		informImage.SetActive (false);
		informImage2.SetActive (false);
		informButton.SetActive (true);
		returnButton.SetActive (false);
		startButton.SetActive (true);
		nextButton.SetActive (false);
		beforeButton.SetActive (false);
	}
}
