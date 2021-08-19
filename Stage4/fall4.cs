using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fall4 : MonoBehaviour {

	public string Ending;

	void Start () {

	}

	void Update () {

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP1 = GameObject.Find ("Swordsman").GetComponent<Player1> ().HP;
		GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP2 = GameObject.Find ("Goblin").GetComponent<Player2> ().HP;

		if (collision.gameObject.tag == "Player")
		{
			GameObject.Find ("bar").GetComponent<underbar> ().life1--;
		//	Destroy (GameObject.Find ("Controllbar"));
			SceneManager.LoadScene(Ending);
		}
		else if (collision.gameObject.tag == "Player2")
		{
			GameObject.Find ("bar").GetComponent<underbar> ().life2--;
		//	Destroy (GameObject.Find ("Controllbar"));
			SceneManager.LoadScene(Ending);
		}
	}
}
