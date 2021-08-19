using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_jump : MonoBehaviour {

	[HideInInspector]
	public bool jump = false;
	public Rigidbody2D rb2d;
	public float jumpForce = 16f;
	public bool grounded;
	public GameObject Net;

	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		Net = GameObject.Find ("Swordsman").GetComponent<Player1_item> ().Net1;
	}
	void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.transform.tag == "Ground")
		{
			grounded = true;
		}
	}

	void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.transform.tag != "Ground")
		{
			grounded = false;
		}
	}
	void Update () {
		if ((Input.GetKeyDown(KeyCode.UpArrow) && grounded)&& (Net.activeSelf==false))
			jump = true;

		if (jump)
		{ 
			Vector3 jumpvelocity = Vector3.up;
			rb2d.AddForce(jumpvelocity*jumpForce, ForceMode2D.Impulse);
			jump = false;
		}
	}
}
