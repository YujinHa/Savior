using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTitle : MonoBehaviour {
	float finishtime = 0f;
	public string Main_menu;
	void Start () {
		Screen.SetResolution (1560,720,false);
	}

	void Update () {
		finishtime = finishtime + Time.deltaTime;
		if (finishtime >= 2f) {
			SceneManager.LoadScene (Main_menu);
		}
	}
}
