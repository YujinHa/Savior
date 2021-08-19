using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_make3 : MonoBehaviour {

	public GameObject[] items = null;
	int rand;
	int[] check = new int[11];

	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () 
	{
		GameObject.Find ("Swordsman").GetComponent<Player1_item> ().stagecheck = 3;
		GameObject.Find ("Goblin").GetComponent<Player2_item> ().stagecheck = 3;
		for (int i = 0; i < 11; i++)
			check [i] = 0;
	}

	void Update () 
	{
		if (Time.time > nextTime)// && nextTime < 200) 
		{
			nextTime = (Time.time + TimeLeft);
			rand = Random.Range(1,12);
			if(check[rand-1]==0)
			{
				GameObject item = GameObject.Instantiate(items[Random.Range (0,12)]) as GameObject;
				if (rand == 1)
					item.transform.position = new Vector2 (-0.19f, -13.14f);
				else if (rand == 2)
					item.transform.position = new Vector2 (1.7f, -3.77f);
				else if (rand == 3)
					item.transform.position = new Vector2 (-17.12f, -3.24f);
				else if (rand == 4)
					item.transform.position = new Vector2 (16.8f, -3.24f);
				else if (rand == 5)
					item.transform.position = new Vector2 (-2.22f, 0.81f);
				else if (rand == 6)
					item.transform.position = new Vector2 (-17.23f, 7.71f);
				else if (rand == 7)
					item.transform.position = new Vector2 (13.9f, 7.3f);
				else if (rand == 8)
					item.transform.position = new Vector2 (-3.27f, 12.94f);
				else if (rand == 9)
					item.transform.position = new Vector2 (6.9f, 12.94f);
				else if (rand == 10)
					item.transform.position = new Vector2 (16.88f, -13.5f);
				else if (rand == 11)
					item.transform.position = new Vector2 (-16.88f, -13.5f);	
				check [rand - 1] = 1;
			}
		}
	}
}
