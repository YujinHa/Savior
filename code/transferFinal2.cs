using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transferFinal2 : MonoBehaviour {

	public string EndingStage;

	void Start () {

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			GameObject.Find ("bar").GetComponent<underbar> ().life2--;
		//	Destroy (GameObject.Find ("Controllbar"));
			SceneManager.LoadScene (EndingStage);
		}
	}
}