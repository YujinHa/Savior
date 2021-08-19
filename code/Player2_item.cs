using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2_item : MonoBehaviour {

	public GameObject ally1 = null;
	public GameObject ally2 = null;
	int rand;
	public GameObject D2;
	public GameObject Heal2;
	public GameObject Net2;

	public int check1 = 0;
	public int check2 = 0;
	public float NetTime;
	public int NetCheck = 0;
	public int bombcheck = 0;
	public int arrowcheck = 0;
	public int stagecheck = 1;

	void Start () {
		D2 = GameObject.FindWithTag ("dynamite2");
		D2.SetActive (false);
		Heal2 = GameObject.FindWithTag ("healing2");
		Heal2.SetActive (false);
		Net2 = GameObject.FindWithTag ("Net2");
		Net2.SetActive (false);
		NetTime = 0f;
	}

	void Update () {
		TimeCheck ();
		bombcheck = 0;
		if (Input.GetKeyDown (KeyCode.RightBracket)&&(GameObject.Find ("bar").GetComponent<underbar> ().d2_count!=0)&&(Time.timeScale != 0f)) {
			if (GameObject.Find ("bar").GetComponent<underbar> ().d2_count == 1) {
				GameObject.Find ("bar").GetComponent<underbar> ().d2_1.enabled = true;
				GameObject.Find ("bar").GetComponent<underbar> ().d2_3.enabled = false;
			}
			GameObject.Find ("bar").GetComponent<underbar> ().d2_count--;
			GameObject.Find ("Swordsman").GetComponent<Player1> ().HP -= 1.2f;
			GameObject.Find ("Explosion2").GetComponent<Explosion2> ().sound5 = 1;

			D2.SetActive (false);
			D2.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.LeftBracket)&&(Time.timeScale != 0f)) {
			if(GameObject.Find ("bar").GetComponent<underbar> ().no2.enabled == false)
				GameObject.Find ("Magic2").GetComponent<Magic2> ().sound6 = 1;//
			GameObject.Find ("bar").GetComponent<underbar> ().no2.enabled = true;
			GameObject.Find ("bar").GetComponent<underbar> ().item_count2 = 0;
			if (GameObject.Find ("bar").GetComponent<underbar> ().bomb2.enabled == true)
			{
				bombcheck = 1;
				check1 = 0;
				check2 = 0;
				GameObject.Find ("bar").GetComponent<underbar> ().bomb2.enabled = false;
			}
			else if(GameObject.Find ("bar").GetComponent<underbar> ().arrow2.enabled == true)
			{
				arrowcheck = 1;
				GameObject.Find ("bar").GetComponent<underbar> ().arrow2.enabled = false;
			}
			else if(GameObject.Find ("bar").GetComponent<underbar> ().net2.enabled == true){
				Net2.SetActive (false);
				Net2.SetActive (true);
				NetTime = 0f;
				NetCheck = 1;
				TimeCheck();
				GameObject.Find ("bar").GetComponent<underbar> ().net2.enabled = false;
			}
			else if(GameObject.Find ("bar").GetComponent<underbar> ().teleport2.enabled == true)
			{
				if(stagecheck==1)
					GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position = new Vector2(-9.2f,-8.05f);//상대방 시작 위치로
				else if(stagecheck==2)
					GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position = new Vector2(-33.51f,-2.3f);
				else if(stagecheck==3)
					GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position = new Vector2(-12.4f,-15.21f);
				else if(stagecheck==4)
					GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position = new Vector2(-7.4f,-28.51f);
			}
			GameObject.Find ("bar").GetComponent<underbar> ().teleport2.enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.O)&&(Time.timeScale != 0f)) {
			if (GameObject.Find ("bar").GetComponent<underbar> ().add3_count > 0) {
				GameObject.Find ("bar").GetComponent<underbar> ().add3_count--;

				if (GameObject.Find ("Goblin").GetComponent<Player2> ().facingRight)
					Instantiate (ally1, new Vector3 (GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.x - 2, GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.y, 0f), Quaternion.identity);
				else
					Instantiate (ally1, new Vector3 (GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.x + 2, GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.y, 0f), Quaternion.identity);
			}
		}
		if (Input.GetKeyDown (KeyCode.P)&&(Time.timeScale != 0f)) {
			if (GameObject.Find ("bar").GetComponent<underbar> ().add4_count > 0) {
				GameObject.Find ("bar").GetComponent<underbar> ().add4_count--;

				if(GameObject.Find ("Goblin").GetComponent<Player2> ().facingRight)
					Instantiate (ally2, new Vector3 (GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.x - 2, GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.y, 0f), Quaternion.identity);
				else
					Instantiate (ally2, new Vector3 (GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.x + 2, GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position.y, 0f), Quaternion.identity);
			}
		}
		if (underbar.instance != null) {
			GameObject.Find ("bar").GetComponent<underbar> ().SetText ();
		}
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag ("add3")) {
			collision.gameObject.SetActive (false);
			GameObject.Find ("bar").GetComponent<underbar> ().add3_count++;
		} else if (collision.gameObject.CompareTag ("add4")) {
			collision.gameObject.SetActive (false);
			GameObject.Find ("bar").GetComponent<underbar> ().add4_count++;
		} else if (collision.gameObject.CompareTag ("add1")) {
			collision.gameObject.SetActive (false);
		} else if (collision.gameObject.CompareTag ("add2")) {
			collision.gameObject.SetActive (false);
		}
		else if (collision.gameObject.CompareTag ("bomb_item1")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().bomb2.enabled = true;
		}
		else if (collision.gameObject.CompareTag ("heal")) {
			collision.gameObject.SetActive(false);
			GameObject.Find ("Goblin").GetComponent<Player2> ().HP = 2.5f;
			Heal2.SetActive (false);
			Heal2.SetActive (true);
		}
		else if (collision.gameObject.CompareTag ("arrow_item1")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().arrow2.enabled = true;
		}
		else if (collision.gameObject.CompareTag ("mystery")) {
			collision.gameObject.SetActive(false);
			mysteryRandom();
		}
		else if (collision.gameObject.CompareTag ("D1_2")) {
			collision.gameObject.SetActive(false);
		}
		else if (collision.gameObject.CompareTag ("D2_2")) {
			collision.gameObject.SetActive(false);
			D2Check();
		}
		else if (collision.gameObject.CompareTag ("net_item")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().net2.enabled = true;
		}
		else if (collision.gameObject.CompareTag ("teleport_item")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().teleport2.enabled = true;
		}
		GameObject.Find ("bar").GetComponent<underbar> ().SetText ();
	}

	void GetItemInit()
	{
		if (GameObject.Find ("bar").GetComponent<underbar> ().item_count2 == 0) {
			GameObject.Find ("bar").GetComponent<underbar> ().item_count2 = 1;
			GameObject.Find ("bar").GetComponent<underbar> ().no2.enabled = false;
		} else {
			GameObject.Find ("bar").GetComponent<underbar> ().SetInitItemImage2 ();
			GameObject.Find ("bar").GetComponent<underbar> ().no2.enabled = false;
		}
	}

	void mysteryRandom()
	{
		rand = Random.Range(1,8);
		if (rand == 1)
			GameObject.Find ("bar").GetComponent<underbar> ().add3_count++;
		else if (rand == 2)
			GameObject.Find ("bar").GetComponent<underbar> ().add4_count++;
		else if (rand == 3) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().bomb2.enabled = true;
		} else if (rand == 4) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().arrow2.enabled = true;
		} else if (rand == 5)
			D2Check ();
		else if (rand == 6) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().net2.enabled = true;
		} else if (rand == 7) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().teleport2.enabled = true;
		}
	}

	void D2Check()
	{
		GameObject.Find ("bar").GetComponent<underbar> ().d2_check++;

		if (GameObject.Find ("bar").GetComponent<underbar> ().d2_check == 1) {
			GameObject.Find ("bar").GetComponent<underbar> ().d2_1.enabled = false;
			GameObject.Find ("bar").GetComponent<underbar> ().d2_3.enabled = false;
			GameObject.Find ("bar").GetComponent<underbar> ().d2_2.enabled = true;
		}
		else if (GameObject.Find ("bar").GetComponent<underbar> ().d2_check == 2) {
			GameObject.Find ("bar").GetComponent<underbar> ().d2_count++;
			GameObject.Find ("bar").GetComponent<underbar> ().d2_2.enabled = false;
			GameObject.Find ("bar").GetComponent<underbar> ().d2_3.enabled = true;
			GameObject.Find ("bar").GetComponent<underbar> ().d2_check = 0;
		}
	}

	void TimeCheck(){
		if(NetCheck==1){
			NetTime += Time.deltaTime;
			if (NetTime > 5) {
				Net2.SetActive (false);
				NetTime = 0;
				NetCheck = 0;
			}
		}
	}
}
