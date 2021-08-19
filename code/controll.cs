using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controll : MonoBehaviour {
	public GameObject controllButton;
	public GameObject controll_page;
	public GameObject controllButtoning;
	public bool iscontrolled = false;

	void Start () {
		controll_page.SetActive (false);
		controllButton.SetActive(true);
		controllButtoning.SetActive (false);
	}

	void Controll ()
	{
		if(iscontrolled.Equals(false)){
			Time.timeScale = 0f;
			controll_page.SetActive(true);
			iscontrolled = true;
			controllButton.SetActive(false);
			controllButtoning.SetActive (true);
		}
		else{
			Time.timeScale = 1f;
			controll_page.SetActive (false);
			controllButton.SetActive(true);
			iscontrolled = false;
			controllButton.SetActive(true);
			controllButtoning.SetActive (false);
		}
	}
}
