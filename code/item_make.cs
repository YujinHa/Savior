using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_make : MonoBehaviour {

	public GameObject[] items = null;
	int rand;
	int[] check = new int[13];

	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () 
	{
		GameObject.Find ("Swordsman").GetComponent<Player1_item> ().stagecheck = 1;
		GameObject.Find ("Goblin").GetComponent<Player2_item> ().stagecheck = 1;
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
					item.transform.position = new Vector2 (-17f, 8.5f);
				else if(rand == 2)
					item.transform.position = new Vector2(-15f,6f);
				else if(rand == 3)
					item.transform.position = new Vector2(-11f,3f);
				else if(rand == 4)
					item.transform.position = new Vector2(-5f,0.5f);
				else if(rand == 5)
					item.transform.position = new Vector2(-13f,-3f);
				else if(rand == 6)
					item.transform.position = new Vector2(-1f,6f);
				else if(rand == 7)
					item.transform.position = new Vector2(3f,-2.5f);
				else if(rand == 8)
					item.transform.position = new Vector2(13f,8.5f);
				else if(rand == 9)
					item.transform.position = new Vector2(7f,6f);
				else if(rand == 10)
					item.transform.position = new Vector2(12f,3f);			
				else if(rand == 11)
					item.transform.position = new Vector2(17.5f,0f);			
				else if(rand == 12)
					item.transform.position = new Vector2(15.5f,-2f);			
				else if(rand == 13)
					item.transform.position = new Vector2(-7f,-6f);			
				check [rand - 1] = 1;
			}
		}
	}
}
