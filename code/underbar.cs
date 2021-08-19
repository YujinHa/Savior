using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class underbar : MonoBehaviour {

	static public underbar instance;

	public Image d1_1;
	public Image d1_2;
	public Image d1_3;
	public Image d2_1;
	public Image d2_2;
	public Image d2_3;
	public Image bomb1;
	public Image bomb2;
	public Image arrow1;
	public Image arrow2;
	public Image net1;
	public Image net2;
	public Image no1;
	public Image no2;
	public Image teleport1;
	public Image teleport2;

	public Image life1_1;
	public Image life1_2;
	public Image life1_3;
	public Image life2_1;
	public Image life2_2;
	public Image life2_3;

	public Text d1_countText;
	public Text d2_countText;
	public Text item_count1Text;
	public Text item_count2Text;
	public Text add1_countText;
	public Text add2_countText;
	public Text add3_countText;
	public Text add4_countText;

	public int d1_count;
	public int d2_count;
	public int item_count1;
	public int item_count2;
	public int add1_count;
	public int add2_count;
	public int add3_count;
	public int add4_count;

	public int itemcheck;
	public int itemcheck2;
	public int d1_check;
	public int d2_check;

	public int life1;
	public int life2;
	public float HP1 = 0f;
	public float HP2 = 0f;
//	public static int barcheck = 0;

	void Start () {
		if (instance == null) {
	//		DontDestroyOnLoad (this.gameObject);
			instance = this;
		}
	//	else
	//		Destroy(this.gameObject);*/

		
		d1_1.enabled = true;
		d1_2.enabled = false;
		d1_3.enabled = false;
		d2_1.enabled = true;
		d2_2.enabled = false;
		d2_3.enabled = false;
		SetInitItemImage1 ();
		SetInitItemImage2 ();

		itemcheck = 0;
		itemcheck2 = 0;
		d1_check = 0;
		d2_check = 0;

		d1_count = 0;
		d2_count = 0;
		item_count1 = 0;
		item_count2 = 0;
		add1_count = 3;
		add2_count = 3;
		add3_count = 3;
		add4_count = 3;

		life1 = 3;
		life2 = 3;
		SetText ();
	}

	void Update () {
			DontDestroyOnLoad (this.gameObject);
		if (life1 == 3) {
			life1_1.enabled = true;
			life1_2.enabled = true;
			life1_3.enabled = true;
		} else if (life1 == 2)
			life1_1.enabled = false;
		else if (life1 == 1)
			life1_2.enabled = false;
		else if (life1 == 0)
			life1_3.enabled = false;//1목숨
		
		if (life2 == 3) {
			life2_1.enabled = true;
			life2_2.enabled = true;
			life2_3.enabled = true;
		} else if (life2 == 2)
			life2_1.enabled = false;
		else if (life2 == 1)
			life2_2.enabled = false;
		else if (life2 == 0)
			life2_3.enabled = false;//2목숨
	}

	public void SetText()
	{
		d1_countText.text = d1_count.ToString ();
		d2_countText.text = d2_count.ToString ();
		item_count1Text.text = item_count1.ToString ();
		item_count2Text.text = item_count2.ToString ();
		add1_countText.text = add1_count.ToString ();
		add2_countText.text = add2_count.ToString ();
		add3_countText.text = add3_count.ToString ();
		add4_countText.text = add4_count.ToString ();
	}

	public void SetInitItemImage1()
	{
		bomb1.enabled = false;
		arrow1.enabled = false;
		net1.enabled = false;
		no1.enabled = true;
		teleport1.enabled = false;
	}
	public void SetInitItemImage2()
	{
		bomb2.enabled = false;
		arrow2.enabled = false;
		net2.enabled = false;
		no2.enabled = true;
		teleport2.enabled = false;
	}
}
