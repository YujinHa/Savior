using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_make2 : MonoBehaviour {

	public GameObject[] items = null;
	int rand;
	int[] check = new int[18];

	private float TimeLeft = 1.0f;
	private float nextTime = 2.0f;

	void Start () 
	{
		GameObject.Find ("Swordsman").GetComponent<Player1_item> ().stagecheck = 2;
		GameObject.Find ("Goblin").GetComponent<Player2_item> ().stagecheck = 2;
		for (int i = 0; i < 18; i++)
			check [i] = 0;
	}

	void Update () 
	{
		if (Time.time > nextTime)// && nextTime < 300) 
		{
			nextTime = (Time.time + TimeLeft);
			rand = Random.Range(1,19);
			if(check[rand-1]==0)
			{
				GameObject item = GameObject.Instantiate(items[Random.Range (0,12)]) as GameObject;
				if (rand == 1)
					item.transform.position = new Vector2 (-37.5f, 3f);
				else if(rand == 2)
					item.transform.position = new Vector2(-28f,5.77f);
				else if(rand == 3)
					item.transform.position = new Vector2(-22.88f,8.8f);
				else if(rand == 4)
					item.transform.position = new Vector2(-14.82f,4.5f);
				else if(rand == 5)
					item.transform.position = new Vector2(-18.37f,-2.2f);
				else if(rand == 6)
					item.transform.position = new Vector2(-32.20f,-6.4f);
				else if(rand == 7)
					item.transform.position = new Vector2(-7.8f,-3.8f);
				else if(rand == 8)
					item.transform.position = new Vector2(-8.7f,2.16f);
				else if(rand == 9)
					item.transform.position = new Vector2(-1.99f,0.45f);
				else if(rand == 10)
					item.transform.position = new Vector2(-1.99f,10.25f);			
				else if(rand == 11)
					item.transform.position = new Vector2(7.32f,8.01f);			
				else if(rand == 12)
					item.transform.position = new Vector2(4.67f,-3.65f);			
				else if(rand == 13)
					item.transform.position = new Vector2(16.03f,-2f);		
				else if(rand == 14)
					item.transform.position = new Vector2(19.54f,3.6f);
				else if(rand == 15)
					item.transform.position = new Vector2(26.49f,5.9f);
				else if(rand == 16)
					item.transform.position = new Vector2(32.45f,7.9f);
				else if(rand == 17)
					item.transform.position = new Vector2(37f,3.3f);			
				else if(rand == 18)
					item.transform.position = new Vector2(31.03f,-6.1f);
				check [rand - 1] = 1;
			}
		}
	}
}
