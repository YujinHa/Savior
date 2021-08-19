using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject pausing;
	public GameObject pause;
	public bool ispaused =false;

	void Start ()
    {
		pausing.SetActive (false);
		pause.SetActive (true);
	}

	void Gamepause ()
    {
		if(ispaused.Equals(false)){
			Time.timeScale = 0f;
			pausing.SetActive(true);
			pause.SetActive (false);
			ispaused = true;
		}
		else{
			Time.timeScale = 1f;
			pausing.SetActive (false);
			pause.SetActive (true);
			ispaused = false;
		}
	}
}
