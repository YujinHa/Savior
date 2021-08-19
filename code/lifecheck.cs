using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifecheck : MonoBehaviour {
	
	public int life1 = 0;
	public int life2 = 0;
	public float HP1 = 0f;
	public float HP2 = 0f;

	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}

	void Update () {
		if (underbar.instance != null) {
			GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP1 = GameObject.Find ("Swordsman").GetComponent<Player1> ().HP;
			GameObject.Find ("lifecheck").GetComponent<lifecheck> ().HP2 = GameObject.Find ("Goblin").GetComponent<Player2> ().HP;
			GameObject.Find ("lifecheck").GetComponent<lifecheck> ().life1 = GameObject.Find ("bar").GetComponent<underbar> ().life1;
			GameObject.Find ("lifecheck").GetComponent<lifecheck> ().life2 = GameObject.Find ("bar").GetComponent<underbar> ().life2;
		}
	}
}
