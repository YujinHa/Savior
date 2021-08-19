using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transferFinal1 : MonoBehaviour {

	public string EndingStage;

	void Start () {

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player2")
		{
			GameObject.Find ("bar").GetComponent<underbar> ().life1--;
		//	Destroy (GameObject.Find ("Controllbar"));
			SceneManager.LoadScene (EndingStage);
		}
	}
}