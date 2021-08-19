using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1_2 : MonoBehaviour
{
	public Rigidbody2D rb2d;
	public float moveForce = 6f;
	private Animator anim;
	public GameObject Net;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		Net = GameObject.Find ("Goblin").GetComponent<Player2_item> ().Net2;
	}

	void Update()
	{
	}
	void FixedUpdate()
	{
		Vector2 moveVelocity = Vector2.zero;
		rb2d.velocity = new Vector2(0f,rb2d.velocity.y);
		rb2d.velocity = new Vector2(rb2d.velocity.x,0f);
		if (Input.GetKey (KeyCode.W) && Net.activeSelf == false) {
			moveVelocity = Vector2.up;
			if (rb2d.velocity.y < 5.0f) {
				rb2d.AddForce (moveForce * moveVelocity, ForceMode2D.Impulse);
			}
		}
		if (Input.GetKey (KeyCode.S) && Net.activeSelf == false) {
			moveVelocity = Vector2.down;
			if (rb2d.velocity.y > -5.0f) {
				rb2d.AddForce (moveForce * moveVelocity, ForceMode2D.Impulse);
			}
		}
	}
}
