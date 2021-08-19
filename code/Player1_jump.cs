using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1_jump : MonoBehaviour {
	[HideInInspector]
	public bool jump = false;
	public Rigidbody2D rb2d;
	public GameObject Net;
	public float jumpForce = 16f;
	public bool grounded;

	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		Net = GameObject.Find ("Goblin").GetComponent<Player2_item> ().Net2;
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
		if ((Input.GetKeyDown(KeyCode.W) && grounded) && (Net.activeSelf==false))
		jump = true;
		
		if (jump)
		{
			rb2d.AddForce(Vector2.up *jumpForce, ForceMode2D.Impulse);
			jump = false;
		}
	}
}
