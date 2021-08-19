using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_make4 : MonoBehaviour {

	public GameObject[] items = null;
	int rand;
	int[] check = new int[13];

	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () 
	{
		GameObject.Find ("Swordsman").GetComponent<Player1_item> ().stagecheck = 4;
		GameObject.Find ("Goblin").GetComponent<Player2_item> ().stagecheck = 4;
		for (int i = 0; i < 13; i++)
			check [i] = 0;
	}

	void Update () 
	{
		if (Time.time > nextTime)// && nextTime < 200) 
		{
			nextTime = (Time.time + TimeLeft);
			rand = Random.Range(1,14);
			if(check[rand-1]==0)
			{
				GameObject item = GameObject.Instantiate(items[Random.Range (0,12)]) as GameObject;
				if (rand == 1)
					item.transform.position = new Vector2 (12.78f,-30.78f);
				else if(rand == 2)
					item.transform.position = new Vector2(-9.65f,-32.6f);
				else if(rand == 3)
					item.transform.position = new Vector2(-11.5f,-18.2f);
				else if(rand == 4)
					item.transform.position = new Vector2(6.82f,-19.1f);
				else if(rand == 5)
					item.transform.position = new Vector2(3.1f,-12f);
				else if(rand == 6)
					item.transform.position = new Vector2(-10.51f,-8.98f);
				else if(rand == 7)
					item.transform.position = new Vector2(-0.14f,-1.78f);
				else if(rand == 8)
					item.transform.position = new Vector2(13f,8.5f);
				else if(rand == 9)
					item.transform.position = new Vector2(-10.44f,4.51f);
				else if(rand == 10)
					item.transform.position = new Vector2(5.92f,18.82f);			
				else if(rand == 11)
					item.transform.position = new Vector2(7.7f,28f);			
				else if(rand == 12)
					item.transform.position = new Vector2(-8.11f,28f);			
				else if(rand == 13)
					item.transform.position = new Vector2(0.4f,38.18f);			
				check [rand - 1] = 1;
			}
		}
	}
}
