using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour {

	public static float HP1 = 0;
	public static float HP2 = 0;
	float finishtime = 0f;

	public GameObject HumanWin;
	public GameObject AlianWin;
	public GameObject Same;
	public string Main_menu;

	void Start () {
		GameObject.Find ("Controllbar").SetActive (false);//
	//	Destroy (GameObject.Find ("Controllbar"));
		Destroy (GameObject.Find ("bar"));
		HumanWin.SetActive (false);
		AlianWin.SetActive (false);
		Same.SetActive (false);

		if (GameObject.Find ("lifecheck").GetComponent<lifecheck> ().life1 > GameObject.Find ("lifecheck").GetComponent<lifecheck> ().life2)
			HumanWin.SetActive (true);

		else if (GameObject.Find ("lifecheck").GetComponent<lifecheck> ().life1 < GameObject.Find ("lifecheck").GetComponent<lifecheck> ().life2)
			AlianWin.SetActive (true);
		else {
			if (GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP1 > GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP2)
				HumanWin.SetActive (true);
			else if (GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP1 < GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP2)
				AlianWin.SetActive (true);
			else
				Same.SetActive (true);
		}
	}

	void Update () {
		finishtime = finishtime + Time.deltaTime;
		if (finishtime >= 4f) {
			Destroy(GameObject.Find ("lifecheck"));
			SceneManager.LoadScene (Main_menu);
		}
	}
}
