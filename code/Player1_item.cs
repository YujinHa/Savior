using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_item : MonoBehaviour {

	public GameObject ally1 = null;
	public GameObject ally2 = null;
	int rand;
	public GameObject D1;
	public GameObject Heal1;
	public GameObject Net1;

	public int check1 = 0;
	public int check2 = 0;
	public float NetTime;
	public int NetCheck = 0;
	public int bombcheck = 0;
	public int arrowcheck = 0;
	public int stagecheck = 1;

	void Start () {
		D1 = GameObject.FindWithTag ("dynamite1");
		D1.SetActive (false);
		Heal1 = GameObject.FindWithTag ("healing1");
		Heal1.SetActive (false);
		Net1 = GameObject.FindWithTag ("Net1");
		Net1.SetActive (false);
		NetTime = 0f;
	}
	
	void Update () {
		TimeCheck ();
		bombcheck = 0;
		if (Input.GetKeyDown (KeyCode.BackQuote)&&(GameObject.Find ("bar").GetComponent<underbar> ().d1_count!=0)&&(Time.timeScale != 0f)){
			if (GameObject.Find ("bar").GetComponent<underbar> ().d1_count == 1) {
				GameObject.Find ("bar").GetComponent<underbar> ().d1_1.enabled = true;
				GameObject.Find ("bar").GetComponent<underbar> ().d1_3.enabled = false;
			}
			GameObject.Find ("bar").GetComponent<underbar> ().d1_count--;
			D1.SetActive (false);
			D1.SetActive (true);
			GameObject.Find ("Goblin").GetComponent<Player2> ().HP -= 1.2f;
			GameObject.Find ("Explosion1").GetComponent<Explosion1> ().sound2 = 1;
		}
		if (Input.GetKeyDown (KeyCode.Alpha1)&&(Time.timeScale != 0f)) {
			if(GameObject.Find ("bar").GetComponent<underbar> ().no1.enabled==false)
				GameObject.Find ("Magic1").GetComponent<Magic1> ().sound3 = 1;//
			GameObject.Find ("bar").GetComponent<underbar> ().no1.enabled = true;
			GameObject.Find ("bar").GetComponent<underbar> ().item_count1 = 0;
			if (GameObject.Find ("bar").GetComponent<underbar> ().bomb1.enabled == true) 
			{
				bombcheck = 1;
				check1 = 0;
				check2 = 0;
				GameObject.Find ("bar").GetComponent<underbar> ().bomb1.enabled = false;
			} 
			else if (GameObject.Find ("bar").GetComponent<underbar> ().arrow1.enabled == true)
			{
				arrowcheck = 1;//공격력 2배 표시
				GameObject.Find ("bar").GetComponent<underbar> ().arrow1.enabled = false;
			}
			else if(GameObject.Find ("bar").GetComponent<underbar> ().net1.enabled == true){
				Net1.SetActive (false);
				Net1.SetActive (true);
				NetTime = 0f;
				NetCheck = 1;
				TimeCheck();
				GameObject.Find ("bar").GetComponent<underbar> ().net1.enabled = false;
			}
			else if(GameObject.Find ("bar").GetComponent<underbar> ().teleport1.enabled == true)
			{
				if(stagecheck==1)
					GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position = new Vector2(13.39f,6.9f);//상대방 시작 위치로
				else if(stagecheck==2)
					GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position = new Vector2(32.25f,-2.4f);
				else if(stagecheck==3)
					GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position = new Vector2(12.04f,-15.3f);
				else if(stagecheck==4)
					GameObject.Find ("Goblin").GetComponent<Player2> ().rb2d.position = new Vector2(7.73f,-28.2f);
			}
			GameObject.Find ("bar").GetComponent<underbar> ().teleport1.enabled = false;
		}

		if (Input.GetKeyDown (KeyCode.Alpha2)&&(Time.timeScale != 0f)) {
			if(GameObject.Find ("bar").GetComponent<underbar> ().add1_count > 0){
				GameObject.Find ("bar").GetComponent<underbar> ().add1_count--;

				if(GameObject.Find ("Swordsman").GetComponent<Player1> ().facingRight)
					Instantiate (ally1, new Vector3(GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.x+2,GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.y,0f),Quaternion.identity);
				else
				Instantiate (ally1, new Vector3(GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.x-2,GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.y,0f),Quaternion.identity);
			}
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)&&(Time.timeScale != 0f)) {
			if (GameObject.Find ("bar").GetComponent<underbar> ().add2_count > 0) {
				GameObject.Find ("bar").GetComponent<underbar> ().add2_count--;

				if(GameObject.Find ("Swordsman").GetComponent<Player1> ().facingRight)
					Instantiate (ally2, new Vector3 (GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.x + 2, GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.y,0f),Quaternion.identity);
				else
					Instantiate (ally2, new Vector3 (GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.x - 2, GameObject.Find ("Swordsman").GetComponent<Player1> ().rb2d.position.y,0f),Quaternion.identity);
			}
		}
		if (underbar.instance != null) {
			GameObject.Find ("bar").GetComponent<underbar> ().SetText ();
		}
	}
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag ("add1")) {
			collision.gameObject.SetActive (false);
			GameObject.Find ("bar").GetComponent<underbar> ().add1_count++;
		} else if (collision.gameObject.CompareTag ("add2")) {
			collision.gameObject.SetActive (false);
			GameObject.Find ("bar").GetComponent<underbar> ().add2_count++;
		} else if (collision.gameObject.CompareTag ("add3")) {
			collision.gameObject.SetActive (false);
		} else if (collision.gameObject.CompareTag ("add4")) {
			collision.gameObject.SetActive (false);
		}
		else if (collision.gameObject.CompareTag ("bomb_item1")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().bomb1.enabled = true;
		}
		else if (collision.gameObject.CompareTag ("heal")) {
			collision.gameObject.SetActive(false);
			GameObject.Find ("Swordsman").GetComponent<Player1> ().HP = 2.5f;
			Heal1.SetActive (false);
			Heal1.SetActive (true);
		}
		else if (collision.gameObject.CompareTag ("arrow_item1")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().arrow1.enabled = true;
		}
		else if (collision.gameObject.CompareTag ("mystery")) {
			collision.gameObject.SetActive(false);
			mysteryRandom();
		}
		else if (collision.gameObject.CompareTag ("D1_2")) {
			collision.gameObject.SetActive(false);
			D1Check();
		}
		else if (collision.gameObject.CompareTag ("D2_2")) {
			collision.gameObject.SetActive(false);
		}
		else if (collision.gameObject.CompareTag ("net_item")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().net1.enabled = true;
		}
		else if (collision.gameObject.CompareTag ("teleport_item")) {
			GetItemInit ();
			collision.gameObject.SetActive(false);
			GameObject.Find ("bar").GetComponent<underbar> ().teleport1.enabled = true;
		}
		GameObject.Find ("bar").GetComponent<underbar> ().SetText ();
	}

	void GetItemInit()
	{
		if (GameObject.Find ("bar").GetComponent<underbar> ().item_count1 == 0) {
			GameObject.Find ("bar").GetComponent<underbar> ().item_count1 = 1;
			GameObject.Find ("bar").GetComponent<underbar> ().no1.enabled = false;
		} else {
			GameObject.Find ("bar").GetComponent<underbar> ().SetInitItemImage1 ();
			GameObject.Find ("bar").GetComponent<underbar> ().no1.enabled = false;
		}
	}

	void mysteryRandom()
	{
		rand = Random.Range(1,8);
		if (rand == 1)
			GameObject.Find ("bar").GetComponent<underbar> ().add1_count++;
		else if (rand == 2)
			GameObject.Find ("bar").GetComponent<underbar> ().add2_count++;
		else if (rand == 3) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().bomb1.enabled = true;
		} else if (rand == 4) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().arrow1.enabled = true;
		} else if (rand == 5)
			D1Check ();
		else if (rand == 6) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().net1.enabled = true;
		} else if (rand == 7) {
			GetItemInit ();
			GameObject.Find ("bar").GetComponent<underbar> ().teleport1.enabled = true;
		}
	}

	void D1Check()
	{
		GameObject.Find ("bar").GetComponent<underbar> ().d1_check++;

		if (GameObject.Find ("bar").GetComponent<underbar> ().d1_check == 1) {
			GameObject.Find ("bar").GetComponent<underbar> ().d1_1.enabled = false;
			GameObject.Find ("bar").GetComponent<underbar> ().d1_3.enabled = false;
			GameObject.Find ("bar").GetComponent<underbar> ().d1_2.enabled = true;
		}
		else if (GameObject.Find ("bar").GetComponent<underbar> ().d1_check == 2) {
			GameObject.Find ("bar").GetComponent<underbar> ().d1_count++;
			GameObject.Find ("bar").GetComponent<underbar> ().d1_2.enabled = false;
			GameObject.Find ("bar").GetComponent<underbar> ().d1_3.enabled = true;
			GameObject.Find ("bar").GetComponent<underbar> ().d1_check = 0;
		}
	}

	void TimeCheck(){
		if(NetCheck==1){
			NetTime += Time.deltaTime;
			if (NetTime > 5) {
				Net1.SetActive (false);
				NetTime = 0;
				NetCheck = 0;
			}
		}
	}
}
