using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fall3 : MonoBehaviour {

	public string Stage4;
	public string EndingStage;

	void Start () {
		
	}

	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			GameObject.Find ("bar").GetComponent<underbar> ().life1--;

			if (GameObject.Find ("bar").GetComponent<underbar> ().life1 == 0) {
			//	Destroy (GameObject.Find ("Controllbar"));
				SceneManager.LoadScene (EndingStage);
			}
			else
				SceneManager.LoadScene (Stage4);
		}
		else if (collision.gameObject.tag == "Player2")
		{
			GameObject.Find ("bar").GetComponent<underbar> ().life2--;

			if (GameObject.Find ("bar").GetComponent<underbar> ().life2 == 0) {
			//	Destroy (GameObject.Find ("Controllbar"));
				SceneManager.LoadScene (EndingStage);
			}
			else
				SceneManager.LoadScene (Stage4);
		}
	}
}
